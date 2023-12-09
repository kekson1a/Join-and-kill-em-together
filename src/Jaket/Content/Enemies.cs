namespace Jaket.Content;

using System.Collections.Generic;
using UnityEngine;

using Jaket.Assets;
using Jaket.Net;
using Jaket.Net.Types;

/// <summary> List of all enemies in the game and some useful methods. </summary>
public class Enemies
{
    /// <summary> List of prefabs of all enemies. </summary>
    public static List<EnemyIdentifier> Prefabs = new();

    /// <summary> Loads all enemies for future use. </summary>
    public static void Load()
    {
        foreach (var name in GameAssets.Enemies) Prefabs.Add(GameAssets.Enemy(name).GetComponentInChildren<EnemyIdentifier>());
    }

    /// <summary> Finds the entity type by enemy class and type, taking into account the fact that some enemies have the same types. </summary>
    public static EntityType Type(EnemyIdentifier enemyId)
    {
        // find object name without clone ending
        string name = enemyId.gameObject.name;
        name = name.Contains("(") ? name.Substring(0, name.IndexOf("(")).Trim() : name;

        // there are the necessary crutches, because the developer incorrectly set the types of some opponents
        if (name.StartsWith("V2 Green Arm")) return EntityType.V2_GreenArm;
        if (name == "Very Cancerous Rodent") return EntityType.VeryCancerousRodent;
        if (name == "Mandalore") return EntityType.Mandalore;

        if (name == "Flesh Prison 2") return EntityType.FleshPanopticon;
        if (name == "DroneFlesh") return EntityType.FleshPrison_Eye;
        if (name == "DroneSkull Variant") return EntityType.FleshPanopticon_Face;

        // the remaining enemies can be found by their type
        int index = Prefabs.FindIndex(prefab => prefab.enemyClass == enemyId.enemyClass && prefab.enemyType == enemyId.enemyType);
        return index == -1 ? EntityType.None : (EntityType)index;
    }
    public static EntityType Type(Entity entity) => entity.EnemyId == null ? EntityType.None : Type(entity.EnemyId);

    /// <summary> Spawns an enemy with the given type. </summary>
    public static Enemy Instantiate(EntityType type)
    {
        // Malicious face's enemyId is in a child object
        // https://discord.com/channels/1132614140414935070/1132614140876292190/1146507403102257162
        var obj = type != EntityType.MaliciousFace ?
                Object.Instantiate(Prefabs[(int)type].gameObject) :
                Object.Instantiate(Prefabs[(int)type].transform.parent.gameObject).transform.GetChild(0).gameObject;

        // for some reasons, the size of the Cerberus is smaller than necessary
        if (type == EntityType.Cerberus) obj.transform.localScale = new(4f, 4f, 4f);

        return obj.AddComponent<Enemy>();
    }

    /// <summary> Synchronizes the enemy between host and clients. </summary>
    public static bool Sync(EnemyIdentifier enemyId)
    {
        if (LobbyController.Lobby == null) return true;

        // I don't even want to know why this happens
        if (enemyId.dead) return true;
        // level 0-2 contains several cutscenes that don't need to be removed
        if (SceneHelper.CurrentScene == "Level 0-2" && enemyId.enemyType == EnemyType.Swordsmachine && enemyId.GetComponent<BossHealthBar>() == null) return true;
        // levels 2-4 and 5-4 contain unique bosses that needs to be dealt with separately
        if (SceneHelper.CurrentScene == "Level 2-4" && enemyId.gameObject.name == "MinosArm")
        {
            enemyId.gameObject.AddComponent<Hand>();
            return true;
        }
        if (SceneHelper.CurrentScene == "Level 5-4" && enemyId.enemyType == EnemyType.Leviathan)
        {
            enemyId.gameObject.AddComponent<Leviathan>();
            return true;
        }

        // the enemy was created remotely
        if (enemyId.gameObject.name == "Net")
        {
            enemyId.GetComponent<Enemy>()?.SpawnEffect();
            return true;
        }
        if (LobbyController.IsOwner)
        {
            if (enemyId.GetComponent<Enemy>() == null) enemyId.gameObject.AddComponent<Enemy>(); // sometimes the game copies enemies
            return true;
        }
        else
        {
            // ask host to spawn enemy if it was spawned via sandbox arm
            if (enemyId.GetComponent<Sandbox.SandboxEnemy>() != null)
                Networking.Send(PacketType.SpawnEntity, w =>
                {
                    w.Enum(Enemies.Type(enemyId));
                    w.Vector(enemyId.transform.position);
                }, size: 13);

            // the enemy is no longer needed, so destroy it
            if (enemyId.enemyType == EnemyType.MaliciousFace && enemyId.gameObject.name == "Body")
                Object.DestroyImmediate(enemyId.transform.parent.gameObject); // avoid a huge number of errors in the console
            else
                Object.DestroyImmediate(enemyId.gameObject);

            return false;
        }
    }
}