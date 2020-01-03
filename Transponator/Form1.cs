using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transponator
{
    public partial class Form1 : Form
    {
        private Transponator transponator;
        private int shift;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            transponator = new Transponator();
            shift = 0;
        }

        private void ShowOutput(int shift_difference)
        {
            shift += shift_difference;

            if (shift < 0) shift = 12 - (Math.Abs(shift) % 12); // Posun proti smeru hodinovych rucicek
            shift %= 12;

            Array result = transponator.GetOutput(richTextBoxInput.Text, shift);

            labelShift.Text = (shift != 0)
                ? shift.ToString() + " (-" + (12 - shift).ToString() + ")"
                : "0";

            listBoxOutput.Items.Clear();

            foreach (var item in result)
            {
                listBoxOutput.Items.Add(item);
            }
        }

        private void buttonMinusOne_Click(object sender, EventArgs e)
        {
            ShowOutput(-1);
        }

        private void buttonPlusOne_Click(object sender, EventArgs e)
        {
            ShowOutput(1);
        }

        private void buttonMinusTwo_Click(object sender, EventArgs e)
        {
            ShowOutput(-2);
        }

        private void buttonPlusTwo_Click(object sender, EventArgs e)
        {
            ShowOutput(2);
        }

        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            ShowOutput(0);
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBoxOutput.SelectedItem is null))
            {
                string item = listBoxOutput.SelectedItem.ToString();
                webBrowserNakresHmatu.Navigate(transponator.GetImageUrl(item));
            }
        }

        private void konecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oAplikaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "© Štěpán Pešout \n \n" + 
                "Online verze: http://transponator.pesout.eu \n" + 
                "Zdroj schémat hmatů: http://akordiky.cz", 
                
                "O aplikaci");
        }

        private void oPultonViceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput(1);
        }

        private void oDvaPultonyViceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput(2);
        }

        private void oPultonMeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput(-1);
        }

        private void oDvaPultonyMeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowOutput(-2);
        }

        private void buttonUlozit_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Soubor aplikace Transponator (*.trsp)|*.trsp";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, richTextBoxInput.Text);
                MessageBox.Show("Uložení problěhlo v pořádku", "Úspěch");
            }
        }

        private void buttonNahrat_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Soubor aplikace Transponator (*.trsp)|*.trsp";

            string file_content;
            string file_path;

            if (open.ShowDialog() == DialogResult.OK)
            {
                file_path = open.FileName;
                var file_stream = open.OpenFile();

                using (StreamReader reader = new StreamReader(file_stream))
                {
                    file_content = reader.ReadToEnd();
                }

                richTextBoxInput.Text = file_content;
                ShowOutput(0);
            }
        }

        private void webBrowserNakresHmatu_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowserNakresHmatu.DocumentText.Contains("HTTP 404"))
            {
                webBrowserNakresHmatu.Navigate("");
            }
        }


        // --- --- --- TODO --- --- ---
        // komentare!!!
        // save a load do classy
        // tlacitko ulozit i v menu stripu
    }
}
