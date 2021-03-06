﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transponator
{
    /// <summary>
    /// Trida implementuje transpozici formaovaneho akordu podle chromatickeho kruhu
    /// </summary>
    class Transpose
    {
        private string[] chords_all;

        public Transpose()
        {
            chords_all = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "B", "H" };
        }

        private string GetChordBase(string chord) 
        {
            // Vetveni podle toho, jestli jde o krizkovy akord
            return (chord.Length > 1 && chord[1] == '#')
                ? chord.Substring(0, 2) 
                : chord.Substring(0, 1);
        }

        private string GetChordType(string chord)
        {
            // Vetveni podle toho, jestli jde o krizkovy akord
            return (chord.Length > 1 && chord[1] == '#') 
                ? chord.Substring(2)
                : chord.Substring(1);
        }
        /// <summary>
        /// Transponuje akord
        /// </summary>
        /// <param name="chord">Formatovany akord</param>
        /// <param name="shift">Pocet pultonu, o ktere posunout po chromatickem kruhu</param>
        /// <returns>Transponovany akord nebo "not_valid"</returns>
        public string TransposeChord(string chord, int shift)
        {
            string chord_base = GetChordBase(chord);
            string chord_type = GetChordType(chord);

            if (!chords_all.Contains(chord_base)) return "not_valid";

            int position = Array.IndexOf(chords_all, chord_base);
            int index;

            if (shift < 0) shift = 12 - (Math.Abs(shift) % 12); // Posun proti smeru hodinovych rucicek
            
            index = (position + shift) % 12; // Kruh ma 12 pultonu          
            string transposed_base = chords_all[index];

            return transposed_base + chord_type;  
        }
    }
}
