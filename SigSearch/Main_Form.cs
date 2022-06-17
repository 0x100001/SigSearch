using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using FastColoredTextBoxNS;

namespace SigSearch
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Check folders
            Check_Folders();
            Helper.Load_YARA_Rules.Do();

            //Check if YARA exe exists
            bool yara_exists = false;
            yara_exists = Check_YARA_Exe();
        }

        //Check folders
        public static void Check_Folders()
        {
            try
            {
                if (Directory.Exists(Application.StartupPath + @"\Sigs\YARA") == false)
                    Directory.CreateDirectory(Application.StartupPath + @"\Sigs\YARA");

                if (Directory.Exists(Application.StartupPath + @"\Results") == false)
                    Directory.CreateDirectory(Application.StartupPath + @"\Results");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't check folders: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Check yara exe
        public static bool Check_YARA_Exe()
        {
            try
            {
                if (File.Exists(Application.StartupPath + @"\yara64.exe"))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("YARA executable is missing. Please make sure it's located unter app_path\\yara64.exe", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't check yara executable: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void selected_rule_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Read_Rule();
        }

        private void Read_Rule()
        {
            try
            {
                yara_rule_editor_textbox.Text = File.ReadAllText(Application.StartupPath + @"\Sigs\YARA\" + yara_selected_rule_combobox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Read rule: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yara_save_button_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(Application.StartupPath + @"\Sigs\YARA\" + yara_selected_rule_combobox.SelectedItem.ToString(), yara_rule_editor_textbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Read rule: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yara_delete_rule_button_Click(object sender, EventArgs e)
        {
            string rule_name = yara_selected_rule_combobox.SelectedItem.ToString();

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                File.Delete(Application.StartupPath + @"\Sigs\YARA\" + yara_selected_rule_combobox.SelectedItem.ToString());
                MessageBox.Show("Deleted rule: " + rule_name, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                yara_selected_rule_combobox.Items.Clear();
                yara_rule_editor_textbox.Clear();
                Helper.Load_YARA_Rules.Do();
            }
        }

        private void yara_new_rule_button_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<YARA.Add_New_Rule.Add_New_Rule>().Count() == 1)
                return;

            var form = new YARA.Add_New_Rule.Add_New_Rule();
            form.Show();
        }

        private void yara_scan_button_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyyMMddHHmmss");

            //Check if rule selected
            if (yara_selected_rule_combobox.SelectedIndex < 0)
            {
                MessageBox.Show("No rule selected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (yara_search_path_chckbox.Checked)
            {
                try
                {
                    Process yara_proc = new Process();
                    yara_proc.StartInfo.UseShellExecute = false;
                    yara_proc.StartInfo.RedirectStandardOutput = true;
                    yara_proc.StartInfo.CreateNoWindow = true;
                    yara_proc.StartInfo.FileName = Application.StartupPath + @"\yara64.exe";
                    yara_proc.StartInfo.Arguments = yara_search_args_textbox.Text + " " + @" """ + Application.StartupPath + @"\Sigs\YARA\" + yara_selected_rule_combobox.SelectedItem.ToString() + "\" \"" + yara_search_path_textbox.Text + "\"";
                    yara_proc.Start();
                    string result = yara_proc.StandardOutput.ReadToEnd(); //Collect Output
                    yara_proc.WaitForExit();
                    yara_search_results_textbox.Text = result;

                    File.AppendAllText(Application.StartupPath + @"\Results\path_" + date + ".txt", yara_search_results_textbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Scan failed: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (yara_search_proc_chckbox.Checked)
            {
                try
                {
                    Process yara_proc = new Process();
                    yara_proc.StartInfo.UseShellExecute = false;
                    yara_proc.StartInfo.RedirectStandardOutput = true;
                    yara_proc.StartInfo.CreateNoWindow = true;
                    yara_proc.StartInfo.FileName = Application.StartupPath + @"\yara64.exe";
                    yara_proc.StartInfo.Arguments = yara_search_args_textbox.Text + " " + @" """ + Application.StartupPath + @"\Sigs\YARA\" + yara_selected_rule_combobox.SelectedItem.ToString() + "\" \"" + yara_search_proc_textbox.Text + "\"";
                    yara_proc.Start();
                    string result = yara_proc.StandardOutput.ReadToEnd(); //Collect Output
                    yara_proc.WaitForExit();
                    yara_search_results_textbox.Text = result;

                    File.AppendAllText(Application.StartupPath + @"\Results\proc_" + date + ".txt", yara_search_results_textbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Scan failed: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (yara_scan_all_processes_checkbox.Checked)
            {
                var allProcesses = Process.GetProcesses();

                foreach (var process in allProcesses)
                {
                    try
                    {
                        Process yara_proc = new Process();
                        yara_proc.StartInfo.UseShellExecute = false;
                        yara_proc.StartInfo.RedirectStandardOutput = true;
                        yara_proc.StartInfo.CreateNoWindow = true;
                        yara_proc.StartInfo.FileName = Application.StartupPath + @"\yara64.exe";
                        yara_proc.StartInfo.Arguments = yara_search_args_textbox.Text + " " + @" """ + Application.StartupPath + @"\Sigs\YARA\" + yara_selected_rule_combobox.SelectedItem.ToString() + "\" \"" + process.Id + "\"";
                        yara_proc.Start();
                        string result = yara_proc.StandardOutput.ReadToEnd(); //Collect Output
                        yara_proc.WaitForExit();

                        //If result
                        if (!String.IsNullOrEmpty(result))
                            yara_search_results_textbox.AppendText(result + " Process name: " + process.ProcessName + "(" + process.Id + ")" + " Path: " + process.MainModule.FileName + Environment.NewLine + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        yara_search_results_textbox.AppendText("Error: " + ex.Message + " Process name: " + process.ProcessName + "(" + process.Id + ")" + Environment.NewLine + Environment.NewLine);
                    }
                }

                File.AppendAllText(Application.StartupPath + @"\Results\all_proc_" + date + ".txt", yara_search_results_textbox.Text);
            }
            else if (yara_scan_all_processes_binaries_checkbox.Checked)
            {
                var allProcesses = Process.GetProcesses();

                foreach (var process in allProcesses)
                {
                    try
                    {
                        Process yara_proc = new Process();
                        yara_proc.StartInfo.UseShellExecute = false;
                        yara_proc.StartInfo.RedirectStandardOutput = true;
                        yara_proc.StartInfo.CreateNoWindow = true;
                        yara_proc.StartInfo.FileName = Application.StartupPath + @"\yara64.exe";
                        yara_proc.StartInfo.Arguments = yara_search_args_textbox.Text + " " + @" """ + Application.StartupPath + @"\Sigs\YARA\" + yara_selected_rule_combobox.SelectedItem.ToString() + "\" \"" + process.MainModule.FileName + "\"";
                        yara_proc.Start();
                        string result = yara_proc.StandardOutput.ReadToEnd(); //Collect Output
                        yara_proc.WaitForExit();

                        //If result
                        if (!String.IsNullOrEmpty(result))
                            yara_search_results_textbox.AppendText(result + " Process name: " + process.ProcessName + "(" + process.Id + ")" + " Path: " + process.MainModule.FileName + Environment.NewLine + Environment.NewLine);
                    }
                    catch (Exception ex)
                    {
                        yara_search_results_textbox.AppendText("Error: " + ex.Message + " Process name: " + process.ProcessName + "(" + process.Id + ")" + Environment.NewLine + Environment.NewLine);
                    }
                }

                File.AppendAllText(Application.StartupPath + @"\Results\all_proc_binaries_" + date + ".txt", yara_search_results_textbox.Text);
            }
            else
            {
                MessageBox.Show("You need to select a scan option.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Scan finished.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void yara_search_proc_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yara_search_proc_chckbox.Checked == true)
            {
                yara_search_path_chckbox.Checked = false;
                yara_scan_all_processes_checkbox.Checked = false;
                yara_scan_all_processes_binaries_checkbox.Checked = false;
            }
        }

        private void yara_search_path_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yara_search_path_chckbox.Checked == true)
            {
                yara_search_proc_chckbox.Checked = false;
                yara_scan_all_processes_checkbox.Checked = false;
                yara_scan_all_processes_binaries_checkbox.Checked = false;
            }
        }

        private void link_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/0x100001/SigSearch");
        }

        private void yara_scan_all_processes_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yara_scan_all_processes_checkbox.Checked == true)
            {
                yara_search_path_chckbox.Checked = false;
                yara_search_proc_chckbox.Checked = false;
                yara_scan_all_processes_binaries_checkbox.Checked = false;
            }
        }

        private void yara_scan_all_processes_binaries_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (yara_scan_all_processes_binaries_checkbox.Checked == true)
            {
                yara_scan_all_processes_checkbox.Checked = false;
                yara_search_path_chckbox.Checked = false;
                yara_search_proc_chckbox.Checked = false;
            }
        }
    }
}
