namespace Jaket.UI.Dialogs;

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.Extensions;

using Jaket.IO;
using Jaket.Net;

using static Pal;
using static Rect;

/// <summary> Tab containing different information about the load on the network. </summary>
public class Debugging : CanvasSingleton<Debugging>
{
    /// <summary> Graphs displaying different values related to the load on the network. </summary>
    private UILineRenderer readGraph, writeGraph, readTimeGraph, writeTimeGraph;
    /// <summary> Data array in the last 157 seconds. </summary>
    private Data read = new(), write = new(), readTime = new(), writeTime = new();
    /// <summary> Text fields containing diverse info about the network state. </summary>
    private Text readText, writeText, readTimeText, writeTimeText, entities, owner, impact;

    private void Start()
    {
        Events.OnLobbyAction += () =>
        {
            if (LobbyController.Offline) readText.text = writeText.text = readTimeText.text = writeTimeText.text = entities.text = owner.text = impact.text = "-";
        };
        Events.EverySecond += UpdateGraph;

        Text DoubleText(Transform table, string name, float y, Color? color = null)
        {
            UIB.Text(name, table, Btn(0f, y), color, align: TextAnchor.MiddleLeft);
            return UIB.Text("-", table, Btn(0f, y), color, align: TextAnchor.MiddleRight);
        }

        // write colors are darker
        Color dark_green = Color.Lerp(green, black, .4f), dark_orange = Color.Lerp(orange, black, .4f);

        UIB.Table("Graph", transform, Msg(1888f) with { y = 114f, Height = 196f }, table =>
        {
            writeTimeGraph = UIB.Line("Write Time", table, dark_orange);
            readTimeGraph = UIB.Line("Read Time", table, orange);
            writeGraph = UIB.Line("Write", table, dark_green);
            readGraph = UIB.Line("Read", table, green);
        });
        UIB.Table("Stats", transform, Deb(0), table =>
        {
            readText = DoubleText(table, "READ:", 20f, green);
            writeText = DoubleText(table, "WRITE:", 52f, dark_green);
            readTimeText = DoubleText(table, "READ TIME:", 84f, orange);
            writeTimeText = DoubleText(table, "WRITE TIME:", 116f, dark_orange);
        });
        UIB.Table("Networking", transform, Deb(1), table =>
        {
            entities = DoubleText(table, "ENTITIES:", 20f);
            owner = DoubleText(table, "IS OWNER:", 52f);
            impact = DoubleText(table, "IMPACT ON FPS:", 84f, red);
        });
    }

    private void UpdateGraph()
    {
        if (!Shown) return;

        #region graph

        read.Enqueue(Stats.LastRead); readTime.Enqueue(Stats.ReadTime);
        write.Enqueue(Stats.LastWrite); writeTime.Enqueue(Stats.WriteTime);

        float peak = Mathf.Max(2048, read.Max(), write.Max());
        readGraph.Points = read.Project(peak);
        writeGraph.Points = write.Project(peak);

        peak = Mathf.Max(.1f, readTime.Max(), writeTime.Max());
        readTimeGraph.Points = readTime.Project(peak);
        writeTimeGraph.Points = writeTime.Project(peak);

        #endregion

        if (LobbyController.Offline) return;

        #region stats

        readText.text = $"{Stats.LastRead}b/s";
        writeText.text = $"{Stats.LastWrite}b/s";
        readTimeText.text = $"{Stats.ReadTime:0.0000}ms";
        writeTimeText.text = $"{Stats.WriteTime:0.0000}ms";

        #endregion
        #region networking

        entities.text = Networking.Entities.Count(p => p.Value != null).ToString();
        owner.text = LobbyController.IsOwner.ToString().ToUpper();
        owner.color = LobbyController.IsOwner ? green : red;
        impact.text = $"{(Stats.ReadTime + Stats.WriteTime) / 10f / Stats.DeltaTimeOnRecord:0.00}%";

        #endregion
    }

    /// <summary> Toggles visibility of the graph. </summary>
    public void Toggle() => gameObject.SetActive(Shown = !Shown);

    /// <summary> Clears the graph. </summary>
    public void Clear() { read.Clear(); write.Clear(); readTime.Clear(); writeTime.Clear(); }

    /// <summary> Constatnt size queue. </summary>
    private class Data : Queue<float>
    {
        public new void Enqueue(float value)
        {
            base.Enqueue(value);
            if (Count > 157) Dequeue();
        }

        public Vector2[] Project(float peak)
        {
            float x = -12f;
            return this.ToList().ConvertAll(v => new Vector2(x += 12f, v / peak * 180f)).ToArray();
        }
    }
}
