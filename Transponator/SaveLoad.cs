using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transponator
{
    /// <summary>
    /// Trida implementuje ukladani a nahravani souboru s akordy k transpozici
    /// </summary>
    class SaveLoad
    {
        /// <summary>
        /// Otevre dialog a necha uzivatele ulozit obsah jako .trsp soubor
        /// </summary>
        /// <param name="data">Obsah textboxu</param>
        public static void Save(string data)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Soubor aplikace Transponator (*.trsp)|*.trsp";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(save.FileName, data);
                MessageBox.Show("Uložení problěhlo v pořádku", "Úspěch");
            }
        }

        /// <summary>
        /// Otevre dialog a necha uzivatele nahrat obsah z .trsp souboru
        /// </summary>
        /// <returns>Nahrany obsah nebo "load_error"</returns>
        public static string Load()
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

                return file_content;
            }

            else return "load_error";
        }
    }
}
