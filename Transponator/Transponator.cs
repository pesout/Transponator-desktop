using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transponator
{
    /// <summary>
    /// Trida implementuje zpracovani a formatovani vystupu na zaklade vstupu
    /// </summary>
    class Transponator
    {
        /// <summary>
        /// Vraci hotove pole pripravene pro vypsani
        /// </summary>
        /// <param name="input">Cely neupraveny vstup od uzivatele</param>
        /// <param name="shift">Pocet pultonu, o ktere se ma posouvat</param>
        public Array GetOutput(string input, int shift)
        {
            String[] lines = input.Split('\n');
            List<string> output = new List<string>();
            List<string> invalid= new List<string>();

            Transpose transpose = new Transpose();

            foreach (var line in lines)
            {
                string chord;
                chord = ChordFormatter.FormatChord(line);
                if (chord.Length == 0) continue;

                try
                {
                    string chord_transposed = transpose.TransposeChord(chord, shift);
                    if (chord_transposed == "not_valid") throw new Exception();
                    output.Add(chord + "  →  " + chord_transposed);
                } 
                catch
                {
                    output.Add(chord + "  →  " + "Nevalidní akord!");
                }
            }

            return output.ToArray();
        }
    }
}
