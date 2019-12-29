using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            listBox_output.Items.Add("ahoj");
            listBox_output.Items.Add("vvvv");
            listBox_output.Items.Add("eeeeeee");
            listBox_output.Items.Add("xxxx");
        }

        private void listBox_output_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(listBox_output.SelectedItem is null))
            {
                string curItem = listBox_output.SelectedItem.ToString();
                MessageBox.Show(curItem);
            }     
        }

        private void button_transpose_Click(object sender, EventArgs e)
        {
            String[] lines = richTextBox_input.Text.Split('\n');
            foreach (var line in lines)
            {
                char[] charsToTrim = { ',', ' ' };
                string chord = line.Trim(charsToTrim).Trim(); // ???
                if (chord != "")
                {
                    MessageBox.Show("---" + chord + "---");
                }               
            }
        }
    }
}
