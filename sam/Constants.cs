namespace Jaket.Sam;

using System.Collections.Generic;

/// <summary> Contains all the constants used by the tts engine, many of which I couldn't understand. </summary>
public class Constants
{
    #region rules

    /// <summary> Set of rules that in some way known only to God changes the pronunciation of phonemes. </summary>
    public static readonly int[] RulesSet1 = new[]
    {
        ']','A'|0x80,
        ' ','(','A','.',')',                    '=','E','H','4','Y','.',' '|0x80,
        '(','A',')',' ',                        '=','A','H'|0x80,
        ' ','(','A','R','E',')',' ',            '=','A','A','R'|0x80,
        ' ','(','A','R',')','O',                '=','A','X','R'|0x80,
        '(','A','R',')','#',                    '=','E','H','4','R'|0x80,
        ' ','^','(','A','S',')','#',            '=','E','Y','4','S'|0x80,
        '(','A',')','W','A',                    '=','A','X'|0x80,
        '(','A','W',')',                        '=','A','O','5'|0x80,
        ' ',':','(','A','N','Y',')',            '=','E','H','4','N','I','Y'|0x80,
        '(','A',')','^','+','#',                '=','E','Y','5'|0x80,
        '#',':','(','A','L','L','Y',')',        '=','U','L','I','Y'|0x80,
        ' ','(','A','L',')','#',                '=','U','L'|0x80,
        '(','A','G','A','I','N',')',            '=','A','X','G','E','H','4','N'|0x80,
        '#',':','(','A','G',')','E',            '=','I','H','J'|0x80,
        '(','A',')','^','%',                    '=','E','Y'|0x80,
        '(','A',')','^','+',':','#',            '=','A','E'|0x80,
        ' ',':','(','A',')','^','+',' ',        '=','E','Y','4'|0x80,
        ' ','(','A','R','R',')',                '=','A','X','R'|0x80,
        '(','A','R','R',')',                    '=','A','E','4','R'|0x80,
        ' ','^','(','A','R',')',' ',            '=','A','A','5','R'|0x80,
        '(','A','R',')',                        '=','A','A','5','R'|0x80,
        '(','A','I','R',')',                    '=','E','H','4','R'|0x80,
        '(','A','I',')',                        '=','E','Y','4'|0x80,
        '(','A','Y',')',                        '=','E','Y','5'|0x80,
        '(','A','U',')',                        '=','A','O','4'|0x80,
        '#',':','(','A','L',')',' ',            '=','U','L'|0x80,
        '#',':','(','A','L','S',')',' ',        '=','U','L','Z'|0x80,
        '(','A','L','K',')',                    '=','A','O','4','K'|0x80,
        '(','A','L',')','^',                    '=','A','O','L'|0x80,
        ' ',':','(','A','B','L','E',')',        '=','E','Y','4','B','U','L'|0x80,
        '(','A','B','L','E',')',                '=','A','X','B','U','L'|0x80,
        '(','A',')','V','O',                    '=','E','Y','4'|0x80,
        '(','A','N','G',')','+',                '=','E','Y','4','N','J'|0x80,
        '(','A','T','A','R','I',')',            '=','A','H','T','A','A','4','R','I','Y'|0x80,
        '(','A',')','T','O','M',                '=','A','E'|0x80,
        '(','A',')','T','T','I',                '=','A','E'|0x80,
        ' ','(','A','T',')',' ',                '=','A','E','T'|0x80,
        ' ','(','A',')','T',                    '=','A','H'|0x80,
        '(','A',')',                            '=','A','E'|0x80,

        ']','B'|0x80,
        ' ','(','B',')',' ',                    '=','B','I','Y','4'|0x80,
        ' ','(','B','E',')','^','#',            '=','B','I','H'|0x80,
        '(','B','E','I','N','G',')',            '=','B','I','Y','4','I','H','N','X'|0x80,
        ' ','(','B','O','T','H',')',' ',        '=','B','O','W','4','T','H'|0x80,
        ' ','(','B','U','S',')','#',            '=','B','I','H','4','Z'|0x80,
        '(','B','R','E','A','K',')',            '=','B','R','E','Y','5','K'|0x80,
        '(','B','U','I','L',')',                '=','B','I','H','4','L'|0x80,
        '(','B',')',                            '=','B'|0x80,

        ']','C'|0x80,
        ' ','(','C',')',' ',                    '=','S','I','Y','4'|0x80,
        ' ','(','C','H',')','^',                '=','K'|0x80,
        '^','E','(','C','H',')',                '=','K'|0x80,
        '(','C','H','A',')','R','#',            '=','K','E','H','5'|0x80,
        '(','C','H',')',                        '=','C','H'|0x80,
        ' ','S','(','C','I',')','#',            '=','S','A','Y','4'|0x80,
        '(','C','I',')','A',                    '=','S','H'|0x80,
        '(','C','I',')','O',                    '=','S','H'|0x80,
        '(','C','I',')','E','N',                '=','S','H'|0x80,
        '(','C','I','T','Y',')',                '=','S','I','H','T','I','Y'|0x80,
        '(','C',')','+',                        '=','S'|0x80,
        '(','C','K',')',                        '=','K'|0x80,
        '(','C','O','M','M','O','D','O','R','E',')','=','K','A','A','4','M','A','H','D','O','H','R'|0x80,
        '(','C','O','M',')',                    '=','K','A','H','M'|0x80,
        '(','C','U','I','T',')',                '=','K','I','H','T'|0x80,
        '(','C','R','E','A',')',                '=','K','R','I','Y','E','Y'|0x80,
        '(','C',')',                            '=','K'|0x80,

        ']','D'|0x80,
        ' ','(','D',')',' ',                    '=','D','I','Y','4'|0x80,
        ' ','(','D','R','.',')',' ',            '=','D','A','A','4','K','T','E','R'|0x80,
        '#',':','(','D','E','D',')',' ',        '=','D','I','H','D'|0x80,
        '.','E','(','D',')',' ',                '=','D'|0x80,
        '#',':','^','E','(','D',')',' ',        '=','T'|0x80,
        ' ','(','D','E',')','^','#',            '=','D','I','H'|0x80,
        ' ','(','D','O',')',' ',                '=','D','U','W'|0x80,
        ' ','(','D','O','E','S',')',            '=','D','A','H','Z'|0x80,
        '(','D','O','N','E',')',' ',            '=','D','A','H','5','N'|0x80,
        '(','D','O','I','N','G',')',            '=','D','U','W','4','I','H','N','X'|0x80,
        ' ','(','D','O','W',')',                '=','D','A','W'|0x80,
        '#','(','D','U',')','A',                '=','J','U','W'|0x80,
        '#','(','D','U',')','^','#',            '=','J','A','X'|0x80,
        '(','D',')',                            '=','D'|0x80,

        ']','E'|0x80,
        ' ','(','E',')',' ',                    '=','I','Y','I','Y','4'|0x80,
        '#',':','(','E',')',' ','='|0x80,
        '\'',':','^','(','E',')',' ','='|0x80,
        ' ',':','(','E',')',' ',                '=','I','Y'|0x80,
        '#','(','E','D',')',' ',                '=','D'|0x80,
        '#',':','(','E',')','D',' ','='|0x80,
        '(','E','V',')','E','R',                '=','E','H','4','V'|0x80,
        '(','E',')','^','%',                    '=','I','Y','4'|0x80,
        '(','E','R','I',')','#',                '=','I','Y','4','R','I','Y'|0x80,
        '(','E','R','I',')',                    '=','E','H','4','R','I','H'|0x80,
        '#',':','(','E','R',')','#',            '=','E','R'|0x80,
        '(','E','R','R','O','R',')',            '=','E','H','4','R','O','H','R'|0x80,
        '(','E','R','A','S','E',')',            '=','I','H','R','E','Y','5','S'|0x80,
        '(','E','R',')','#',                    '=','E','H','R'|0x80,
        '(','E','R',')',                        '=','E','R'|0x80,
        ' ','(','E','V','E','N',')',            '=','I','Y','V','E','H','N'|0x80,
        '#',':','(','E',')','W','='|0x80,
        '@','(','E','W',')',                    '=','U','W'|0x80,
        '(','E','W',')',                        '=','Y','U','W'|0x80,
        '(','E',')','O',                        '=','I','Y'|0x80,
        '#',':','&','(','E','S',')',' ',        '=','I','H','Z'|0x80,
        '#',':','(','E',')','S',' ','='|0x80,
        '#',':','(','E','L','Y',')',' ',        '=','L','I','Y'|0x80,
        '#',':','(','E','M','E','N','T',')',    '=','M','E','H','N','T'|0x80,
        '(','E','F','U','L',')',                '=','F','U','H','L'|0x80,
        '(','E','E',')',                        '=','I','Y','4'|0x80,
        '(','E','A','R','N',')',                '=','E','R','5','N'|0x80,
        ' ','(','E','A','R',')','^',            '=','E','R','5'|0x80,
        '(','E','A','D',')',                    '=','E','H','D'|0x80,
        '#',':','(','E','A',')',' ',            '=','I','Y','A','X'|0x80,
        '(','E','A',')','S','U',                '=','E','H','5'|0x80,
        '(','E','A',')',                        '=','I','Y','5'|0x80,
        '(','E','I','G','H',')',                '=','E','Y','4'|0x80,
        '(','E','I',')',                        '=','I','Y','4'|0x80,
        ' ','(','E','Y','E',')',                '=','A','Y','4'|0x80,
        '(','E','Y',')',                        '=','I','Y'|0x80,
        '(','E','U',')',                        '=','Y','U','W','5'|0x80,
        '(','E','Q','U','A','L',')',            '=','I','Y','4','K','W','U','L'|0x80,
        '(','E',')',                            '=','E','H'|0x80,

        ']','F'|0x80,
        ' ','(','F',')',' ',                    '=','E','H','4','F'|0x80,
        '(','F','U','L',')',                    '=','F','U','H','L'|0x80,
        '(','F','R','I','E','N','D',')',        '=','F','R','E','H','5','N','D'|0x80,
        '(','F','A','T','H','E','R',')',        '=','F','A','A','4','D','H','E','R'|0x80,
        '(','F',')','F','='|0x80,
        '(','F',')',                            '=','F'|0x80,

        ']','G'|0x80,
        ' ','(','G',')',' ',                    '=','J','I','Y','4'|0x80,
        '(','G','I','V',')',                    '=','G','I','H','5','V'|0x80,
        ' ','(','G',')','I','^',                '=','G'|0x80,
        '(','G','E',')','T',                    '=','G','E','H','5'|0x80,
        'S','U','(','G','G','E','S',')',        '=','G','J','E','H','4','S'|0x80,
        '(','G','G',')',                        '=','G'|0x80,
        ' ','B','#','(','G',')',                '=','G'|0x80,
        '(','G',')','+',                        '=','J'|0x80,
        '(','G','R','E','A','T',')',            '=','G','R','E','Y','4','T'|0x80,
        '(','G','O','N',')','E',                '=','G','A','O','5','N'|0x80,
        '#','(','G','H',')','='|0x80,
        ' ','(','G','N',')',                    '=','N'|0x80,
        '(','G',')',                            '=','G'|0x80,

        ']','H'|0x80,
        ' ','(','H',')',' ',                    '=','E','Y','4','C','H'|0x80,
        ' ','(','H','A','V',')',                '=','/','H','A','E','6','V'|0x80,
        ' ','(','H','E','R','E',')',            '=','/','H','I','Y','R'|0x80,
        ' ','(','H','O','U','R',')',            '=','A','W','5','E','R'|0x80,
        '(','H','O','W',')',                    '=','/','H','A','W'|0x80,
        '(','H',')','#',                        '=','/','H'|0x80,
        '(','H',')','='|0x80,

        ']','I'|0x80,
        ' ','(','I','N',')',                    '=','I','H','N'|0x80,
        ' ','(','I',')',' ',                    '=','A','Y','4'|0x80,
        '(','I',')',' ',                        '=','A','Y'|0x80,
        '(','I','N',')','D',                    '=','A','Y','5','N'|0x80,
        'S','E','M','(','I',')',                '=','I','Y'|0x80,
        ' ','A','N','T','(','I',')',            '=','A','Y'|0x80,
        '(','I','E','R',')',                    '=','I','Y','E','R'|0x80,
        '#',':','R','(','I','E','D',')',' ',    '=','I','Y','D'|0x80,
        '(','I','E','D',')',' ',                '=','A','Y','5','D'|0x80,
        '(','I','E','N',')',                    '=','I','Y','E','H','N'|0x80,
        '(','I','E',')','T',                    '=','A','Y','4','E','H'|0x80,
        '(','I','\'',')',                        '=','A','Y','5'|0x80,
        ' ',':','(','I',')','^','%',            '=','A','Y','5'|0x80,
        ' ',':','(','I','E',')',' ',            '=','A','Y','4'|0x80,
        '(','I',')','%',                        '=','I','Y'|0x80,
        '(','I','E',')',                        '=','I','Y','4'|0x80,
        ' ','(','I','D','E','A',')',            '=','A','Y','D','I','Y','5','A','H'|0x80,
        '(','I',')','^','+',':','#',            '=','I','H'|0x80,
        '(','I','R',')','#',                    '=','A','Y','R'|0x80,
        '(','I','Z',')','%',                    '=','A','Y','Z'|0x80,
        '(','I','S',')','%',                    '=','A','Y','Z'|0x80,
        'I','^','(','I',')','^','#',            '=','I','H'|0x80,
        '+','^','(','I',')','^','+',            '=','A','Y'|0x80,
        '#',':','^','(','I',')','^','+',        '=','I','H'|0x80,
        '(','I',')','^','+',                    '=','A','Y'|0x80,
        '(','I','R',')',                        '=','E','R'|0x80,
        '(','I','G','H',')',                    '=','A','Y','4'|0x80,
        '(','I','L','D',')',                    '=','A','Y','5','L','D'|0x80,
        ' ','(','I','G','N',')',                '=','I','H','G','N'|0x80,
        '(','I','G','N',')',' ',                '=','A','Y','4','N'|0x80,
        '(','I','G','N',')','^',                '=','A','Y','4','N'|0x80,
        '(','I','G','N',')','%',                '=','A','Y','4','N'|0x80,
        '(','I','C','R','O',')',                '=','A','Y','4','K','R','O','H'|0x80,
        '(','I','Q','U','E',')',                '=','I','Y','4','K'|0x80,
        '(','I',')',                            '=','I','H'|0x80,

        ']','J'|0x80,
        ' ','(','J',')',' ',                    '=','J','E','Y','4'|0x80,
        '(','J',')',                            '=','J'|0x80,

        ']','K'|0x80,
        ' ','(','K',')',' ',                    '=','K','E','Y','4'|0x80,
        ' ','(','K',')','N','='|0x80,
        '(','K',')',                            '=','K'|0x80,

        ']','L'|0x80,
        ' ','(','L',')',' ',                    '=','E','H','4','L'|0x80,
        '(','L','O',')','C','#',                '=','L','O','W'|0x80,
        'L','(','L',')','='|0x80,
        '#',':','^','(','L',')','%',            '=','U','L'|0x80,
        '(','L','E','A','D',')',                '=','L','I','Y','D'|0x80,
        ' ','(','L','A','U','G','H',')',        '=','L','A','E','4','F'|0x80,
        '(','L',')',                            '=','L'|0x80,

        ']','M'|0x80,
        ' ','(','M',')',' ',                    '=','E','H','4','M'|0x80,
        ' ','(','M','R','.',')',' ',            '=','M','I','H','4','S','T','E','R'|0x80,
        ' ','(','M','S','.',')',                '=','M','I','H','5','Z'|0x80,
        ' ','(','M','R','S','.',')',' ',        '=','M','I','H','4','S','I','X','Z'|0x80,
        '(','M','O','V',')',                    '=','M','U','W','4','V'|0x80,
        '(','M','A','C','H','I','N',')',        '=','M','A','H','S','H','I','Y','5','N'|0x80,
        'M','(','M',')','='|0x80,
        '(','M',')',                            '=','M'|0x80,

        ']','N'|0x80,
        ' ','(','N',')',' ',                    '=','E','H','4','N'|0x80,
        'E','(','N','G',')','+',                '=','N','J'|0x80,
        '(','N','G',')','R',                    '=','N','X','G'|0x80,
        '(','N','G',')','#',                    '=','N','X','G'|0x80,
        '(','N','G','L',')','%',                '=','N','X','G','U','L'|0x80,
        '(','N','G',')',                        '=','N','X'|0x80,
        '(','N','K',')',                        '=','N','X','K'|0x80,
        ' ','(','N','O','W',')',' ',            '=','N','A','W','4'|0x80,
        'N','(','N',')','='|0x80,
        '(','N','O','N',')','E',                '=','N','A','H','4','N'|0x80,
        '(','N',')',                            '=','N'|0x80,

        ']','O'|0x80,
        ' ','(','O',')',' ',                    '=','O','H','4','W'|0x80,
        '(','O','F',')',' ',                    '=','A','H','V'|0x80,
        ' ','(','O','H',')',' ',                '=','O','W','5'|0x80,
        '(','O','R','O','U','G','H',')',        '=','E','R','4','O','W'|0x80,
        '#',':','(','O','R',')',' ',            '=','E','R'|0x80,
        '#',':','(','O','R','S',')',' ',        '=','E','R','Z'|0x80,
        '(','O','R',')',                        '=','A','O','R'|0x80,
        ' ','(','O','N','E',')',                '=','W','A','H','N'|0x80,
        '#','(','O','N','E',')',' ',            '=','W','A','H','N'|0x80,
        '(','O','W',')',                        '=','O','W'|0x80,
        ' ','(','O','V','E','R',')',            '=','O','W','5','V','E','R'|0x80,
        'P','R','(','O',')','V',                '=','U','W','4'|0x80,
        '(','O','V',')',                        '=','A','H','4','V'|0x80,
        '(','O',')','^','%',                    '=','O','W','5'|0x80,
        '(','O',')','^','E','N',                '=','O','W'|0x80,
        '(','O',')','^','I','#',                '=','O','W','5'|0x80,
        '(','O','L',')','D',                    '=','O','W','4','L'|0x80,
        '(','O','U','G','H','T',')',            '=','A','O','5','T'|0x80,
        '(','O','U','G','H',')',                '=','A','H','5','F'|0x80,
        ' ','(','O','U',')',                    '=','A','W'|0x80,
        'H','(','O','U',')','S','#',            '=','A','W','4'|0x80,
        '(','O','U','S',')',                    '=','A','X','S'|0x80,
        '(','O','U','R',')',                    '=','O','H','R'|0x80,
        '(','O','U','L','D',')',                '=','U','H','5','D'|0x80,
        '(','O','U',')','^','L',                '=','A','H','5'|0x80,
        '(','O','U','P',')',                    '=','U','W','5','P'|0x80,
        '(','O','U',')',                        '=','A','W'|0x80,
        '(','O','Y',')',                        '=','O','Y'|0x80,
        '(','O','I','N','G',')',                '=','O','W','4','I','H','N','X'|0x80,
        '(','O','I',')',                        '=','O','Y','5'|0x80,
        '(','O','O','R',')',                    '=','O','H','5','R'|0x80,
        '(','O','O','K',')',                    '=','U','H','5','K'|0x80,
        'F','(','O','O','D',')',                '=','U','W','5','D'|0x80,
        'L','(','O','O','D',')',                '=','A','H','5','D'|0x80,
        'M','(','O','O','D',')',                '=','U','W','5','D'|0x80,
        '(','O','O','D',')',                    '=','U','H','5','D'|0x80,
        'F','(','O','O','T',')',                '=','U','H','5','T'|0x80,
        '(','O','O',')',                        '=','U','W','5'|0x80,
        '(','O','\'',')',                        '=','O','H'|0x80,
        '(','O',')','E',                        '=','O','W'|0x80,
        '(','O',')',' ',                        '=','O','W'|0x80,
        '(','O','A',')',                        '=','O','W','4'|0x80,
        ' ','(','O','N','L','Y',')',            '=','O','W','4','N','L','I','Y'|0x80,
        ' ','(','O','N','C','E',')',            '=','W','A','H','4','N','S'|0x80,
        '(','O','N','\'','T',')',                '=','O','W','4','N','T'|0x80,
        'C','(','O',')','N',                    '=','A','A'|0x80,
        '(','O',')','N','G',                    '=','A','O'|0x80,
        ' ',':','^','(','O',')','N',            '=','A','H'|0x80,
        'I','(','O','N',')',                    '=','U','N'|0x80,
        '#',':','(','O','N',')',                '=','U','N'|0x80,
        '#','^','(','O','N',')',                '=','U','N'|0x80,
        '(','O',')','S','T',                    '=','O','W'|0x80,
        '(','O','F',')','^',                    '=','A','O','4','F'|0x80,
        '(','O','T','H','E','R',')',            '=','A','H','5','D','H','E','R'|0x80,
        'R','(','O',')','B',                    '=','R','A','A'|0x80,
        '^','R','(','O',')',':','#',            '=','O','W','5'|0x80,
        '(','O','S','S',')',' ',                '=','A','O','5','S'|0x80,
        '#',':','^','(','O','M',')',            '=','A','H','M'|0x80,
        '(','O',')',                            '=','A','A'|0x80,

        ']','P'|0x80,
        ' ','(','P',')',' ',                    '=','P','I','Y','4'|0x80,
        '(','P','H',')',                        '=','F'|0x80,
        '(','P','E','O','P','L',')',            '=','P','I','Y','5','P','U','L'|0x80,
        '(','P','O','W',')',                    '=','P','A','W','4'|0x80,
        '(','P','U','T',')',' ',                '=','P','U','H','T'|0x80,
        '(','P',')','P','='|0x80,
        '(','P',')','S','='|0x80,
        '(','P',')','N','='|0x80,
        '(','P','R','O','F','.',')',            '=','P','R','O','H','F','E','H','4','S','E','R'|0x80,
        '(','P',')',                            '=','P'|0x80,

        ']','Q'|0x80,
        ' ','(','Q',')',' ',                    '=','K','Y','U','W','4'|0x80,
        '(','Q','U','A','R',')',                '=','K','W','O','H','5','R'|0x80,
        '(','Q','U',')',                        '=','K','W'|0x80,
        '(','Q',')',                            '=','K'|0x80,
        ']','R'|0x80,
        ' ','(','R',')',' ',                    '=','A','A','5','R'|0x80,
        ' ','(','R','E',')','^','#',            '=','R','I','Y'|0x80,
        '(','R',')','R','='|0x80,
        '(','R',')',                            '=','R'|0x80,

        ']','S'|0x80,
        ' ','(','S',')',' ',                    '=','E','H','4','S'|0x80,
        '(','S','H',')',                        '=','S','H'|0x80,
        '#','(','S','I','O','N',')',            '=','Z','H','U','N'|0x80,
        '(','S','O','M','E',')',                '=','S','A','H','M'|0x80,
        '#','(','S','U','R',')','#',            '=','Z','H','E','R'|0x80,
        '(','S','U','R',')','#',                '=','S','H','E','R'|0x80,
        '#','(','S','U',')','#',                '=','Z','H','U','W'|0x80,
        '#','(','S','S','U',')','#',            '=','S','H','U','W'|0x80,
        '#','(','S','E','D',')',                '=','Z','D'|0x80,
        '#','(','S',')','#',                    '=','Z'|0x80,
        '(','S','A','I','D',')',                '=','S','E','H','D'|0x80,
        '^','(','S','I','O','N',')',            '=','S','H','U','N'|0x80,
        '(','S',')','S','='|0x80,
        '.','(','S',')',' ',                    '=','Z'|0x80,
        '#',':','.','E','(','S',')',' ',        '=','Z'|0x80,
        '#',':','^','#','(','S',')',' ',        '=','S'|0x80,
        'U','(','S',')',' ',                    '=','S'|0x80,
        ' ',':','#','(','S',')',' ',            '=','Z'|0x80,
        '#','#','(','S',')',' ',                '=','Z'|0x80,
        ' ','(','S','C','H',')',                '=','S','K'|0x80,
        '(','S',')','C','+','='|0x80,
        '#','(','S','M',')',                    '=','Z','U','M'|0x80,
        '#','(','S','N',')','\'',                '=','Z','U','M'|0x80,
        '(','S','T','L','E',')',                '=','S','U','L'|0x80,
        '(','S',')',                            '=','S'|0x80,

        ']','T'|0x80,
        ' ','(','T',')',' ',                    '=','T','I','Y','4'|0x80,
        ' ','(','T','H','E',')',' ','#',        '=','D','H','I','Y'|0x80,
        ' ','(','T','H','E',')',' ',            '=','D','H','A','X'|0x80,
        '(','T','O',')',' ',                    '=','T','U','X'|0x80,
        ' ','(','T','H','A','T',')',            '=','D','H','A','E','T'|0x80,
        ' ','(','T','H','I','S',')',' ',        '=','D','H','I','H','S'|0x80,
        ' ','(','T','H','E','Y',')',            '=','D','H','E','Y'|0x80,
        ' ','(','T','H','E','R','E',')',        '=','D','H','E','H','R'|0x80,
        '(','T','H','E','R',')',                '=','D','H','E','R'|0x80,
        '(','T','H','E','I','R',')',            '=','D','H','E','H','R'|0x80,
        ' ','(','T','H','A','N',')',' ',        '=','D','H','A','E','N'|0x80,
        ' ','(','T','H','E','M',')',' ',        '=','D','H','A','E','N'|0x80,
        '(','T','H','E','S','E',')',' ',        '=','D','H','I','Y','Z'|0x80,
        ' ','(','T','H','E','N',')',            '=','D','H','E','H','N'|0x80,
        '(','T','H','R','O','U','G','H',')',    '=','T','H','R','U','W','4'|0x80,
        '(','T','H','O','S','E',')',            '=','D','H','O','H','Z'|0x80,
        '(','T','H','O','U','G','H',')',' ',    '=','D','H','O','W'|0x80,
        '(','T','O','D','A','Y',')',            '=','T','U','X','D','E','Y'|0x80,
        '(','T','O','M','O',')','R','R','O','W','=','T','U','M','A','A','5'|0x80,
        '(','T','O',')','T','A','L',            '=','T','O','W','5'|0x80,
        ' ','(','T','H','U','S',')',            '=','D','H','A','H','4','S'|0x80,
        '(','T','H',')',                        '=','T','H'|0x80,
        '#',':','(','T','E','D',')',            '=','T','I','X','D'|0x80,
        'S','(','T','I',')','#','N',            '=','C','H'|0x80,
        '(','T','I',')','O',                    '=','S','H'|0x80,
        '(','T','I',')','A',                    '=','S','H'|0x80,
        '(','T','I','E','N',')',                '=','S','H','U','N'|0x80,
        '(','T','U','R',')','#',                '=','C','H','E','R'|0x80,
        '(','T','U',')','A',                    '=','C','H','U','W'|0x80,
        ' ','(','T','W','O',')',                '=','T','U','W'|0x80,
        '&','(','T',')','E','N',' ','='|0x80,
        '(','T',')',                            '=','T'|0x80,

        ']','U'|0x80,
        ' ','(','U',')',' ',                    '=','Y','U','W','4'|0x80,
        ' ','(','U','N',')','I',                '=','Y','U','W','N'|0x80,
        ' ','(','U','N',')',                    '=','A','H','N'|0x80,
        ' ','(','U','P','O','N',')',            '=','A','X','P','A','O','N'|0x80,
        '@','(','U','R',')','#',                '=','U','H','4','R'|0x80,
        '(','U','R',')','#',                    '=','Y','U','H','4','R'|0x80,
        '(','U','R',')',                        '=','E','R'|0x80,
        '(','U',')','^',' ',                    '=','A','H'|0x80,
        '(','U',')','^','^',                    '=','A','H','5'|0x80,
        '(','U','Y',')',                        '=','A','Y','5'|0x80,
        ' ','G','(','U',')','#','='|0x80,
        'G','(','U',')','%','='|0x80,
        'G','(','U',')','#',                    '=','W'|0x80,
        '#','N','(','U',')',                    '=','Y','U','W'|0x80,
        '@','(','U',')',                        '=','U','W'|0x80,
        '(','U',')',                            '=','Y','U','W'|0x80,

        ']','V'|0x80,
        ' ','(','V',')',' ',                    '=','V','I','Y','4'|0x80,
        '(','V','I','E','W',')',                '=','V','Y','U','W','5'|0x80,
        '(','V',')',                            '=','V'|0x80,

        ']','W'|0x80,
        ' ','(','W',')',' ',                    '=','D','A','H','4','B','U','L','Y','U','W'|0x80,
        ' ','(','W','E','R','E',')',            '=','W','E','R'|0x80,
        '(','W','A',')','S','H',                '=','W','A','A'|0x80,
        '(','W','A',')','S','T',                '=','W','E','Y'|0x80,
        '(','W','A',')','S',                    '=','W','A','H'|0x80,
        '(','W','A',')','T',                    '=','W','A','A'|0x80,
        '(','W','H','E','R','E',')',            '=','W','H','E','H','R'|0x80,
        '(','W','H','A','T',')',                '=','W','H','A','H','T'|0x80,
        '(','W','H','O','L',')',                '=','/','H','O','W','L'|0x80,
        '(','W','H','O',')',                    '=','/','H','U','W'|0x80,
        '(','W','H',')',                        '=','W','H'|0x80,
        '(','W','A','R',')','#',                '=','W','E','H','R'|0x80,
        '(','W','A','R',')',                    '=','W','A','O','R'|0x80,
        '(','W','O','R',')','^',                '=','W','E','R'|0x80,
        '(','W','R',')',                        '=','R'|0x80,
        '(','W','O','M',')','A',                '=','W','U','H','M'|0x80,
        '(','W','O','M',')','E',                '=','W','I','H','M'|0x80,
        '(','W','E','A',')','R',                '=','W','E','H'|0x80,
        '(','W','A','N','T',')',                '=','W','A','A','5','N','T'|0x80,
        'A','N','S','(','W','E','R',')',        '=','E','R'|0x80,
        '(','W',')',                            '=','W'|0x80,

        ']','X'|0x80,
        ' ','(','X',')',' ',                    '=','E','H','4','K','S'|0x80,
        ' ','(','X',')',                        '=','Z'|0x80,
        '(','X',')',                            '=','K','S'|0x80,

        ']','Y'|0x80,
        ' ','(','Y',')',' ',                    '=','W','A','Y','4'|0x80,
        '(','Y','O','U','N','G',')',            '=','Y','A','H','N','X'|0x80,
        ' ','(','Y','O','U','R',')',            '=','Y','O','H','R'|0x80,
        ' ','(','Y','O','U',')',                '=','Y','U','W'|0x80,
        ' ','(','Y','E','S',')',                '=','Y','E','H','S'|0x80,
        ' ','(','Y',')',                        '=','Y'|0x80,
        'F','(','Y',')',                        '=','A','Y'|0x80,
        'P','S','(','Y','C','H',')',            '=','A','Y','K'|0x80,
        '#',':','^','(','Y',')',                '=','I','Y'|0x80,
        '#',':','^','(','Y',')','I',            '=','I','Y'|0x80,
        ' ',':','(','Y',')',' ',                '=','A','Y'|0x80,
        ' ',':','(','Y',')','#',                '=','A','Y'|0x80,
        ' ',':','(','Y',')','^','+',':','#',    '=','I','H'|0x80,
        ' ',':','(','Y',')','^','#',            '=','A','Y'|0x80,
        '(','Y',')',                            '=','I','H'|0x80,

        ']','Z'|0x80,
        ' ','(','Z',')',' ',                    '=','Z','I','Y','4'|0x80,
        '(','Z',')',                            '=','Z'|0x80,
        'j'|0x80
    };

    /// <summary> Set of rules that in some way known only to God changes the pronunciation of phonemes. </summary>
    public static readonly int[] RulesSet2 = new[]
    {
        '(','A',')',                            '='|0x80,
        '(','!',')',                            '=','.'|0x80,
        '(','"',')',' ',                        '=','-','A','H','5','N','K','W','O','W','T','-'|0x80,
        '(','"',')',                            '=','K','W','O','W','4','T','-'|0x80,
        '(','#',')',                            '=',' ','N','A','H','4','M','B','E','R'|0x80,
        '(','$',')',                            '=',' ','D','A','A','4','L','E','R'|0x80,
        '(','%',')',                            '=',' ','P','E','R','S','E','H','4','N','T'|0x80,
        '(','&',')',                            '=',' ','A','E','N','D'|0x80,
        '(','\'',')',                           '='|0x80,
        '(','*',')',                            '=',' ','A','E','4','S','T','E','R','I','H','S','K'|0x80,
        '(','+',')',                            '=',' ','P','L','A','H','4','S'|0x80,
        '(',',',')',                            '=',','|0x80,
        ' ','(','-',')',' ',                    '=','-'|0x80,
        '(','-',')',                            '='|0x80,
        '(','.',')',                            '=',' ','P','O','Y','N','T'|0x80,
        '(','/',')',                            '=',' ','S','L','A','E','4','S','H'|0x80,
        '(','0',')',                            '=',' ','Z','I','Y','4','R','O','W'|0x80,
        ' ','(','1','S','T',')',                '=','F','E','R','4','S','T'|0x80,
        ' ','(','1','0','T','H',')',            '=','T','E','H','4','N','T','H'|0x80,
        '(','1',')',                            '=',' ','W','A','H','4','N'|0x80,
        ' ','(','2','N','D',')',                '=','S','E','H','4','K','U','N','D'|0x80,
        '(','2',')',                            '=',' ','T','U','W','4'|0x80,
        ' ','(','3','R','D',')',                '=','T','H','E','R','4','D'|0x80,
        '(','3',')',                            '=',' ','T','H','R','I','Y','4'|0x80,
        '(','4',')',                            '=',' ','F','O','H','4','R'|0x80,
        ' ','(','5','T','H',')',                '=','F','I','H','4','F','T','H'|0x80,
        '(','5',')',                            '=',' ','F','A','Y','4','V'|0x80,
        ' ','(','6','4',')',' ',                '=','S','I','H','4','K','S','T','I','Y',' ','F','O','H','R'|0x80,
        '(','6',')',                            '=',' ','S','I','H','4','K','S'|0x80,
        '(','7',')',                            '=',' ','S','E','H','4','V','U','N'|0x80,
        ' ','(','8','T','H',')',                '=','E','Y','4','T','H'|0x80,
        '(','8',')',                            '=',' ','E','Y','4','T'|0x80,
        '(','9',')',                            '=',' ','N','A','Y','4','N'|0x80,
        '(',':',')',                            '=','.'|0x80,
        '(',';',')',                            '=','.'|0x80,
        '(','<',')',                            '=',' ','L','E','H','4','S',' ','D','H','A','E','N'|0x80,
        '(','=',')',                            '=',' ','I','Y','4','K','W','U','L','Z'|0x80,
        '(','>',')',                            '=',' ','G','R','E','Y','4','T','E','R',' ','D','H','A','E','N'|0x80,
        '(','?',')',                            '=','?'|0x80,
        '(','@',')',                            '=',' ','A','E','6','T'|0x80,
        '(','^',')',                            '=',' ','K','A','E','4','R','I','X','T'|0x80,
        ']','A'|0x80
    };

    #endregion
    #region phonemes

    /// <summary> Table of stress characters, using it to find their ids. </summary>
    public static List<char> StressCharTable = new() { '1', '2', '3', '4', '5', '6', '7', '8' };

    /// <summary> Table of phoneme names, using it to find their ids. </summary>
    public static List<string> PhonemeNameTable = new()
    {
        " *", ".*", "?*", ",*", "-*", "IY", "IH", "EH", "AE", "AA", "AH", "AO", "UH", "AX", "IX", "ER",
        "UX", "OH", "RX", "LX", "WX", "YX", "WH", "R*", "L*", "W*", "Y*", "M*", "N*", "NX", "DX", "Q*",
        "S*", "SH", "F*", "TH", "/H", "/X", "Z*", "ZH", "V*", "DH", "CH", "**", "J*", "**", "**", "**",
        "EY", "AY", "OY", "AW", "OW", "UW", "B*", "**", "**", "D*", "**", "**", "G*", "**", "**", "GX",
        "**", "**", "P*", "**", "**", "T*", "**", "**", "K*", "**", "**", "KX", "**", "**", "UL", "UM", "UN"
    };

    /// <summary> Finds the phoneme id that completely matches the given one. </summary>
    public static int FullMatch(char sign1, char sign2)
    {
        string sum = sign1 + "" + sign2; // C# sucks
        return PhonemeNameTable.FindIndex(value => value == sum && value[1] != '*');
    }

    /// <summary> Finds the phoneme id that match the first character with the given one. </summary>
    public static int WildMatch(char sign) => PhonemeNameTable.IndexOf(sign + "*");

    #endregion
    #region other

    /// <summary> Table of phoneme frequencies composed from three original ones. </summary>
    public static readonly int[] PhonemeFrequencyTable = new[] {
        0x000000, 0x5B4313, 0x5B4313, 0x5B4313, 0x5B4313, 0x6E540A, 0x5D490E, 0x5B4313,
        0x583F18, 0x59281B, 0x572C17, 0x581F15, 0x522510, 0x592D14, 0x5D490E, 0x3E3112,
        0x52240E, 0x581E12, 0x3E3312, 0x6E2515, 0x501D0D, 0x5D450F, 0x5A180B, 0x3C3212,
        0x6E1E0E, 0x5A180B, 0x6E5309, 0x512E06, 0x793606, 0x655606, 0x793606, 0x5B4311,
        0x634906, 0x6A4F06, 0x511A06, 0x794206, 0x5D490E, 0x522510, 0x5D3309, 0x67420A,
        0x4C2808, 0x5D2F0A, 0x654F06, 0x654F06, 0x794206, 0x654F05, 0x796E06, 0x000000,
        0x5A4813, 0x58271B, 0x581F15, 0x582B1B, 0x581E12, 0x52220D, 0x511A06, 0x511A06,
        0x511A06, 0x794206, 0x795206, 0x794206, 0x706E06, 0x6E6E06, 0x6E6E06, 0x5E5406,
        0x5E5406, 0x5E5406, 0x511A06, 0x511A06, 0x511A06, 0x794206, 0x794206, 0x794206,
        0x656D06, 0x65560A, 0x706D0A, 0x5E5406, 0x5E5406, 0x5E5406, 0x087F2C, 0x017F13
    };

    /// <summary> Table of phoneme amplitudes composed from three original ones. </summary>
    public static readonly int[] PhonemeAmplitudesTable = new[] {
        0x000000, 0x000000, 0x000000, 0x000000, 0x000000, 0x080A0D, 0x070B0D, 0x080D0E,
        0x080E0F, 0x010D0F, 0x010C0F, 0x000C0F, 0x010B0F, 0x00090C, 0x070B0D, 0x050B0C,
        0x010C0F, 0x000C0F, 0x060C0D, 0x01080D, 0x00080D, 0x070C0E, 0x00080D, 0x050A0C,
        0x01080D, 0x00080D, 0x080A0D, 0x00030C, 0x000909, 0x030609, 0x000000, 0x000000,
        0x000000, 0x000000, 0x000000, 0x000000, 0x000000, 0x000000, 0x00030B, 0x01050B,
        0x00030B, 0x00040B, 0x000000, 0x000000, 0x000001, 0x01050B, 0x0E0A00, 0x010202,
        0x090E0E, 0x010D0F, 0x000C0F, 0x010D0F, 0x000C0F, 0x00080D, 0x000002, 0x000104,
        0x000000, 0x000002, 0x000104, 0x000000, 0x000001, 0x000104, 0x000000, 0x000001,
        0x000104, 0x000000, 0x000000, 0x000000, 0x000000, 0x000000, 0x000000, 0x000000,
        0x000000, 0x070A0C, 0x000000, 0x000000, 0x050A00, 0x000000, 0x13000F, 0x10000F
    };

    /// <summary> Table of phoneme lengths combined from two original ones. </summary>
    public static readonly short[] PhonemeLengthTable = new short[] {
        0x0000, 0x1212, 0x1212, 0x1212, 0x0808, 0x0B08, 0x0908, 0x0B08, //  * .* ?* ,* -* IY IH EH
        0x0E08, 0x0F0B, 0x0B06, 0x100C, 0x0C0A, 0x0605, 0x0605, 0x0E0B, // AE AA AH AO UH AX IX ER
        0x0C0A, 0x0E0A, 0x0C0A, 0x0B09, 0x0808, 0x0807, 0x0B09, 0x0A07, // UX OH RX LX WX YX WH R*
        0x0906, 0x0808, 0x0806, 0x0807, 0x0807, 0x0807, 0x0302, 0x0505, // L* W* Y* M* N* NX DX Q*
        0x0202, 0x0202, 0x0202, 0x0202, 0x0202, 0x0202, 0x0606, 0x0606, // S* SH F* TH /H /X Z* ZH
        0x0807, 0x0606, 0x0606, 0x0202, 0x0908, 0x0403, 0x0201, 0x011E, // V* DH CH ** J* ** ** **
        0x0E0D, 0x0F0C, 0x0F0C, 0x0F0C, 0x0E0E, 0x0E09, 0x0806, 0x0201, // EY AY OY AW OW UW B* **
        0x0202, 0x0705, 0x0201, 0x0101, 0x0706, 0x0201, 0x0202, 0x0706, // ** D* ** ** G* ** ** GX
        0x0201, 0x0202, 0x0808, 0x0202, 0x0202, 0x0604, 0x0202, 0x0202, // ** ** P* ** ** T* ** **
        0x0706, 0x0201, 0x0404, 0x0706, 0x0101, 0x0404, 0x05C7, 0x05FF  // K* ** ** KX ** ** UL UM
    };

    /// <summary> Pre-calculated sine values ​​from -127 to 127. </summary>
    public static readonly short[] Sinus = new short[] {
         0  ,  3  ,  6  ,  9  ,  12 ,  16 ,  19 ,  22 ,  25 ,  28 ,  31 ,  34 ,  37 ,  40 ,  43 ,  46 ,  49 ,  51 ,  54 ,  57 ,  60 ,  63 ,  65 ,  68 ,
         71 ,  73 ,  76 ,  78 ,  81 ,  83 ,  85 ,  88 ,  90 ,  92 ,  94 ,  96 ,  98 ,  100,  102,  104,  106,  107,  109,  111,  112,  113,  115,  116,
         117,  118,  120,  121,  122,  122,  123,  124,  125,  125,  126,  126,  126,  127,  127,  127,  127,  127,  127,  127,  126,  126,  126,  125,
         125,  124,  123,  122,  122,  121,  120,  118,  117,  116,  115,  113,  112,  111,  109,  107,  106,  104,  102,  100,  98 ,  96 ,  94 ,  92 ,
         90 ,  88 ,  85 ,  83 ,  81 ,  78 ,  76 ,  73 ,  71 ,  68 ,  65 ,  63 ,  60 ,  57 ,  54 ,  51 ,  49 ,  46 ,  43 ,  40 ,  37 ,  34 ,  31 ,  28 ,
         25 ,  22 ,  19 ,  16 ,  12 ,  9  ,  6  ,  3  ,  0  , -3  , -6  , -9  , -12 , -16 , -19 , -22 , -25 , -28 , -31 , -34 , -37 , -40 , -43 , -46 ,
        -49 , -51 , -54 , -57 , -60 , -63 , -65 , -68 , -71 , -73 , -76 , -78 , -81 , -83 , -85 , -88 , -90 , -92 , -94 , -96 , -98 , -100, -102, -104,
        -106, -107, -109, -111, -112, -113, -115, -116, -117, -118, -120, -121, -122, -122, -123, -124, -125, -125, -126, -126, -126, -127, -127, -127,
        -127, -127, -127, -127, -126, -126, -126, -125, -125, -124, -123, -122, -122, -121, -120, -118, -117, -116, -115, -113, -112, -111, -109, -107,
        -106, -104, -102, -100, -98 , -96 , -94 , -92 , -90 , -88 , -85 , -83 , -81 , -78 , -76 , -73 , -71 , -68 , -65 , -63 , -60 , -57 , -54 , -51 ,
        -49 , -46 , -43 , -40 , -37 , -34 , -31 , -28 , -25 , -22 , -19 , -16 , -12 , -9  , -6  , -3
    };

    #endregion
}
