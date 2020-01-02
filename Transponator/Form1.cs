using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transponator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxOutput.Items.Add("ahoj");
            listBoxOutput.Items.Add("vvvv");
            listBoxOutput.Items.Add("eeeeeee");
            listBoxOutput.Items.Add("xxxx");
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBoxOutput.SelectedItem is null))
            {
                string curItem = listBoxOutput.SelectedItem.ToString();
                MessageBox.Show(curItem);
            }     
        }

        private void buttonTranspose_Click(object sender, EventArgs e)
        {
            Transpose tr = new Transpose();

            MessageBox.Show("---" + tr.TransposeChord("F#mi7", 1) + "---");
            MessageBox.Show("---" + tr.TransposeChord("F#mi7", 3) + "---");
            MessageBox.Show("---" + tr.TransposeChord("F#mi7", 5) + "---");
            MessageBox.Show("---" + tr.TransposeChord("F#mi7", 7) + "---");
            MessageBox.Show("---" + tr.TransposeChord("F#mi7", 9) + "---");
            MessageBox.Show("---" + tr.TransposeChord("F#mi7", 12) + "---");
            /*
            String[] lines = richTextBoxInput.Text.Split('\n'); // Vstup z textboxu do pole

            foreach (var line in lines)
            {
                string chord = ChordFormatter.FormatChord(line);
                if (chord.Length == 0) continue; // Preskocit prazdne radky

                MessageBox.Show("---" + chord + "---");             
            }
            */
        }

        // --- --- --- TODO --- --- ---
        // komentare!!!
        // selectbox a tlacitka +-
    }
}
