﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Transponator
{
    /// <summary>
    /// Nastroj pro formatovani akordu
    /// </summary>
    class ChordFormatter
    {
        /// <summary>
        /// Vraci formatovany akord bez osklivych znaku, prvni pismeno velke, ostatni mala
        /// </summary>
        /// <param name="chord">Vstupni string se vsemi osklivymi znaky</param>
        /// <returns></returns>
        public static string formatChord(string chord)
        {
            chord = Regex.Replace(chord.Trim(), "[^A-Za-z0-9#]", ""); // Zachovat pouze pismena a cisla v akordech

            if (chord.Length == 0) return ""; // Nejsou zadne validni znaky

            chord = (chord.Length > 0) // Prvni pismeno velke, ostatni mala
                ? char.ToUpper(chord[0]).ToString() + chord.Substring(1).ToLower()
                : char.ToUpper(chord[0]).ToString();

            return chord;
        }
    }

    
}
