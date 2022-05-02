using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SigSearch.Helper
{
    internal class Load_YARA_Rules
    {
        public static void Do()
        {
            try
            {
                var Main_Form_Init = Application.OpenForms.OfType<Main_Form>().FirstOrDefault();

                Main_Form_Init.yara_selected_rule_combobox.Items.Clear();

                foreach (string sig in Directory.GetFiles(Application.StartupPath + @"\Sigs\YARA"))
                {
                    FileInfo fi = new FileInfo(sig);
                    Main_Form_Init.yara_selected_rule_combobox.Items.Add(fi.Name);
                }

                if (Main_Form_Init.yara_selected_rule_combobox.Items.Count > 0)
                    Main_Form_Init.yara_selected_rule_combobox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load sigs: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
