using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SigSearch.YARA.Add_New_Rule
{
    public partial class Add_New_Rule : Form
    {
        public Add_New_Rule()
        {
            InitializeComponent();
        }

        private void Add_New_Rule_Load(object sender, EventArgs e)
        {

        }

        private void yara_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(yara_rule_name_textbox.Text))
                {
                    MessageBox.Show("No rule name defined.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (File.Exists(Application.StartupPath + @"\Sigs\YARA\" + yara_rule_name_textbox.Text))
                {
                    MessageBox.Show("Rule already exists.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    File.WriteAllText(Application.StartupPath + @"\Sigs\YARA\" + yara_rule_name_textbox.Text, yara_rule_editor_textbox.Text);
                    Helper.Load_YARA_Rules.Do();
                    MessageBox.Show("Rule saved: " + yara_rule_name_textbox.Text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Read rule: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
