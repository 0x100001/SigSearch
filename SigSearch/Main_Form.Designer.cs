namespace SigSearch
{
    partial class Main_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.yara_selected_rule_combobox = new System.Windows.Forms.ComboBox();
            this.yara_tabcontrol = new System.Windows.Forms.TabControl();
            this.yara_tabcontrol_search_tab = new System.Windows.Forms.TabPage();
            this.yara_scan_all_processes_checkbox = new System.Windows.Forms.CheckBox();
            this.yara_search_results_textbox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.yara_search_path_chckbox = new System.Windows.Forms.CheckBox();
            this.yara_search_path_textbox = new System.Windows.Forms.TextBox();
            this.yara_search_proc_chckbox = new System.Windows.Forms.CheckBox();
            this.yara_search_proc_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yara_search_args_textbox = new System.Windows.Forms.TextBox();
            this.yara_scan_button = new System.Windows.Forms.Button();
            this.yara_tabcontrol_rule_editor_tab = new System.Windows.Forms.TabPage();
            this.yara_save_button = new System.Windows.Forms.Button();
            this.yara_rule_editor_textbox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.link_label = new System.Windows.Forms.LinkLabel();
            this.yara_delete_rule_button = new System.Windows.Forms.Button();
            this.yara_new_rule_button = new System.Windows.Forms.Button();
            this.yara_scan_all_processes_binaries_checkbox = new System.Windows.Forms.CheckBox();
            this.yara_tabcontrol.SuspendLayout();
            this.yara_tabcontrol_search_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yara_search_results_textbox)).BeginInit();
            this.yara_tabcontrol_rule_editor_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yara_rule_editor_textbox)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected rule:";
            // 
            // yara_selected_rule_combobox
            // 
            this.yara_selected_rule_combobox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yara_selected_rule_combobox.FormattingEnabled = true;
            this.yara_selected_rule_combobox.Location = new System.Drawing.Point(100, 6);
            this.yara_selected_rule_combobox.Name = "yara_selected_rule_combobox";
            this.yara_selected_rule_combobox.Size = new System.Drawing.Size(243, 25);
            this.yara_selected_rule_combobox.TabIndex = 1;
            this.yara_selected_rule_combobox.SelectedIndexChanged += new System.EventHandler(this.selected_rule_combobox_SelectedIndexChanged);
            // 
            // yara_tabcontrol
            // 
            this.yara_tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yara_tabcontrol.Controls.Add(this.yara_tabcontrol_search_tab);
            this.yara_tabcontrol.Controls.Add(this.yara_tabcontrol_rule_editor_tab);
            this.yara_tabcontrol.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yara_tabcontrol.Location = new System.Drawing.Point(6, 37);
            this.yara_tabcontrol.Name = "yara_tabcontrol";
            this.yara_tabcontrol.SelectedIndex = 0;
            this.yara_tabcontrol.Size = new System.Drawing.Size(1330, 654);
            this.yara_tabcontrol.TabIndex = 2;
            // 
            // yara_tabcontrol_search_tab
            // 
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_scan_all_processes_binaries_checkbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_scan_all_processes_checkbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_search_results_textbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_search_path_chckbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_search_path_textbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_search_proc_chckbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_search_proc_textbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.label2);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_search_args_textbox);
            this.yara_tabcontrol_search_tab.Controls.Add(this.yara_scan_button);
            this.yara_tabcontrol_search_tab.Location = new System.Drawing.Point(4, 26);
            this.yara_tabcontrol_search_tab.Name = "yara_tabcontrol_search_tab";
            this.yara_tabcontrol_search_tab.Padding = new System.Windows.Forms.Padding(3);
            this.yara_tabcontrol_search_tab.Size = new System.Drawing.Size(1322, 624);
            this.yara_tabcontrol_search_tab.TabIndex = 0;
            this.yara_tabcontrol_search_tab.Text = "Search";
            this.yara_tabcontrol_search_tab.UseVisualStyleBackColor = true;
            // 
            // yara_scan_all_processes_checkbox
            // 
            this.yara_scan_all_processes_checkbox.AutoSize = true;
            this.yara_scan_all_processes_checkbox.Location = new System.Drawing.Point(974, 8);
            this.yara_scan_all_processes_checkbox.Name = "yara_scan_all_processes_checkbox";
            this.yara_scan_all_processes_checkbox.Size = new System.Drawing.Size(135, 21);
            this.yara_scan_all_processes_checkbox.TabIndex = 16;
            this.yara_scan_all_processes_checkbox.Text = "Scan all processes";
            this.yara_scan_all_processes_checkbox.UseVisualStyleBackColor = true;
            this.yara_scan_all_processes_checkbox.CheckedChanged += new System.EventHandler(this.yara_scan_all_processes_checkbox_CheckedChanged);
            // 
            // yara_search_results_textbox
            // 
            this.yara_search_results_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yara_search_results_textbox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.yara_search_results_textbox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.yara_search_results_textbox.AutoIndentExistingLines = false;
            this.yara_search_results_textbox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.yara_search_results_textbox.BackBrush = null;
            this.yara_search_results_textbox.BackColor = System.Drawing.Color.Transparent;
            this.yara_search_results_textbox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.yara_search_results_textbox.CaretColor = System.Drawing.Color.White;
            this.yara_search_results_textbox.CharHeight = 14;
            this.yara_search_results_textbox.CharWidth = 8;
            this.yara_search_results_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yara_search_results_textbox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.yara_search_results_textbox.FoldingIndicatorColor = System.Drawing.Color.LimeGreen;
            this.yara_search_results_textbox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.yara_search_results_textbox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.yara_search_results_textbox.IsReplaceMode = false;
            this.yara_search_results_textbox.Language = FastColoredTextBoxNS.Language.CSharp;
            this.yara_search_results_textbox.LeftBracket = '(';
            this.yara_search_results_textbox.LeftBracket2 = '{';
            this.yara_search_results_textbox.LineNumberColor = System.Drawing.Color.White;
            this.yara_search_results_textbox.Location = new System.Drawing.Point(3, 37);
            this.yara_search_results_textbox.Name = "yara_search_results_textbox";
            this.yara_search_results_textbox.Paddings = new System.Windows.Forms.Padding(0);
            this.yara_search_results_textbox.ReadOnly = true;
            this.yara_search_results_textbox.RightBracket = ')';
            this.yara_search_results_textbox.RightBracket2 = '}';
            this.yara_search_results_textbox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.yara_search_results_textbox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("yara_search_results_textbox.ServiceColors")));
            this.yara_search_results_textbox.ShowCaretWhenInactive = true;
            this.yara_search_results_textbox.ShowFoldingLines = true;
            this.yara_search_results_textbox.Size = new System.Drawing.Size(1316, 550);
            this.yara_search_results_textbox.TabIndex = 15;
            this.yara_search_results_textbox.WordWrapAutoIndent = false;
            this.yara_search_results_textbox.Zoom = 100;
            // 
            // yara_search_path_chckbox
            // 
            this.yara_search_path_chckbox.AutoSize = true;
            this.yara_search_path_chckbox.Checked = true;
            this.yara_search_path_chckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yara_search_path_chckbox.Location = new System.Drawing.Point(557, 8);
            this.yara_search_path_chckbox.Name = "yara_search_path_chckbox";
            this.yara_search_path_chckbox.Size = new System.Drawing.Size(58, 21);
            this.yara_search_path_chckbox.TabIndex = 14;
            this.yara_search_path_chckbox.Text = "Path:";
            this.yara_search_path_chckbox.UseVisualStyleBackColor = true;
            this.yara_search_path_chckbox.CheckedChanged += new System.EventHandler(this.yara_search_path_chckbox_CheckedChanged);
            // 
            // yara_search_path_textbox
            // 
            this.yara_search_path_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yara_search_path_textbox.Location = new System.Drawing.Point(621, 6);
            this.yara_search_path_textbox.Name = "yara_search_path_textbox";
            this.yara_search_path_textbox.Size = new System.Drawing.Size(347, 25);
            this.yara_search_path_textbox.TabIndex = 13;
            this.yara_search_path_textbox.Text = "C:";
            // 
            // yara_search_proc_chckbox
            // 
            this.yara_search_proc_chckbox.AutoSize = true;
            this.yara_search_proc_chckbox.Location = new System.Drawing.Point(283, 8);
            this.yara_search_proc_chckbox.Name = "yara_search_proc_chckbox";
            this.yara_search_proc_chckbox.Size = new System.Drawing.Size(76, 21);
            this.yara_search_proc_chckbox.TabIndex = 12;
            this.yara_search_proc_chckbox.Text = "Process:";
            this.yara_search_proc_chckbox.UseVisualStyleBackColor = true;
            this.yara_search_proc_chckbox.CheckedChanged += new System.EventHandler(this.yara_search_proc_chckbox_CheckedChanged);
            // 
            // yara_search_proc_textbox
            // 
            this.yara_search_proc_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yara_search_proc_textbox.Location = new System.Drawing.Point(362, 6);
            this.yara_search_proc_textbox.Name = "yara_search_proc_textbox";
            this.yara_search_proc_textbox.Size = new System.Drawing.Size(187, 25);
            this.yara_search_proc_textbox.TabIndex = 9;
            this.yara_search_proc_textbox.Text = "pid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Args:";
            // 
            // yara_search_args_textbox
            // 
            this.yara_search_args_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yara_search_args_textbox.Location = new System.Drawing.Point(51, 6);
            this.yara_search_args_textbox.Name = "yara_search_args_textbox";
            this.yara_search_args_textbox.Size = new System.Drawing.Size(224, 25);
            this.yara_search_args_textbox.TabIndex = 7;
            this.yara_search_args_textbox.Text = "-r";
            // 
            // yara_scan_button
            // 
            this.yara_scan_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yara_scan_button.Location = new System.Drawing.Point(6, 593);
            this.yara_scan_button.Name = "yara_scan_button";
            this.yara_scan_button.Size = new System.Drawing.Size(1310, 25);
            this.yara_scan_button.TabIndex = 5;
            this.yara_scan_button.Text = "Scan";
            this.yara_scan_button.UseVisualStyleBackColor = true;
            this.yara_scan_button.Click += new System.EventHandler(this.yara_scan_button_Click);
            // 
            // yara_tabcontrol_rule_editor_tab
            // 
            this.yara_tabcontrol_rule_editor_tab.Controls.Add(this.yara_save_button);
            this.yara_tabcontrol_rule_editor_tab.Controls.Add(this.yara_rule_editor_textbox);
            this.yara_tabcontrol_rule_editor_tab.Location = new System.Drawing.Point(4, 26);
            this.yara_tabcontrol_rule_editor_tab.Name = "yara_tabcontrol_rule_editor_tab";
            this.yara_tabcontrol_rule_editor_tab.Padding = new System.Windows.Forms.Padding(3);
            this.yara_tabcontrol_rule_editor_tab.Size = new System.Drawing.Size(1322, 624);
            this.yara_tabcontrol_rule_editor_tab.TabIndex = 1;
            this.yara_tabcontrol_rule_editor_tab.Text = "Rule Editor";
            this.yara_tabcontrol_rule_editor_tab.UseVisualStyleBackColor = true;
            // 
            // yara_save_button
            // 
            this.yara_save_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yara_save_button.Location = new System.Drawing.Point(6, 595);
            this.yara_save_button.Name = "yara_save_button";
            this.yara_save_button.Size = new System.Drawing.Size(1310, 23);
            this.yara_save_button.TabIndex = 3;
            this.yara_save_button.Text = "Save rule";
            this.yara_save_button.UseVisualStyleBackColor = true;
            this.yara_save_button.Click += new System.EventHandler(this.yara_save_button_Click);
            // 
            // yara_rule_editor_textbox
            // 
            this.yara_rule_editor_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yara_rule_editor_textbox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.yara_rule_editor_textbox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.yara_rule_editor_textbox.AutoIndentExistingLines = false;
            this.yara_rule_editor_textbox.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.yara_rule_editor_textbox.BackBrush = null;
            this.yara_rule_editor_textbox.BackColor = System.Drawing.Color.Transparent;
            this.yara_rule_editor_textbox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.yara_rule_editor_textbox.CaretColor = System.Drawing.Color.White;
            this.yara_rule_editor_textbox.CharHeight = 14;
            this.yara_rule_editor_textbox.CharWidth = 8;
            this.yara_rule_editor_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yara_rule_editor_textbox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.yara_rule_editor_textbox.FoldingIndicatorColor = System.Drawing.Color.LimeGreen;
            this.yara_rule_editor_textbox.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.yara_rule_editor_textbox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.yara_rule_editor_textbox.IsReplaceMode = false;
            this.yara_rule_editor_textbox.Language = FastColoredTextBoxNS.Language.JS;
            this.yara_rule_editor_textbox.LeftBracket = '(';
            this.yara_rule_editor_textbox.LeftBracket2 = '{';
            this.yara_rule_editor_textbox.LineNumberColor = System.Drawing.Color.White;
            this.yara_rule_editor_textbox.Location = new System.Drawing.Point(0, 0);
            this.yara_rule_editor_textbox.Name = "yara_rule_editor_textbox";
            this.yara_rule_editor_textbox.Paddings = new System.Windows.Forms.Padding(0);
            this.yara_rule_editor_textbox.RightBracket = ')';
            this.yara_rule_editor_textbox.RightBracket2 = '}';
            this.yara_rule_editor_textbox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.yara_rule_editor_textbox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("yara_rule_editor_textbox.ServiceColors")));
            this.yara_rule_editor_textbox.ShowCaretWhenInactive = true;
            this.yara_rule_editor_textbox.ShowFoldingLines = true;
            this.yara_rule_editor_textbox.Size = new System.Drawing.Size(1322, 589);
            this.yara_rule_editor_textbox.TabIndex = 1;
            this.yara_rule_editor_textbox.WordWrapAutoIndent = false;
            this.yara_rule_editor_textbox.Zoom = 100;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1350, 729);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.link_label);
            this.tabPage1.Controls.Add(this.yara_delete_rule_button);
            this.tabPage1.Controls.Add(this.yara_new_rule_button);
            this.tabPage1.Controls.Add(this.yara_tabcontrol);
            this.tabPage1.Controls.Add(this.yara_selected_rule_combobox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 699);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "YARA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // link_label
            // 
            this.link_label.AutoSize = true;
            this.link_label.Location = new System.Drawing.Point(1090, 6);
            this.link_label.Name = "link_label";
            this.link_label.Size = new System.Drawing.Size(242, 17);
            this.link_label.TabIndex = 6;
            this.link_label.TabStop = true;
            this.link_label.Text = "https://github.com/0x100001/SigSearch";
            this.link_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_label_LinkClicked);
            // 
            // yara_delete_rule_button
            // 
            this.yara_delete_rule_button.Location = new System.Drawing.Point(432, 6);
            this.yara_delete_rule_button.Name = "yara_delete_rule_button";
            this.yara_delete_rule_button.Size = new System.Drawing.Size(84, 25);
            this.yara_delete_rule_button.TabIndex = 5;
            this.yara_delete_rule_button.Text = "Delete rule";
            this.yara_delete_rule_button.UseVisualStyleBackColor = true;
            this.yara_delete_rule_button.Click += new System.EventHandler(this.yara_delete_rule_button_Click);
            // 
            // yara_new_rule_button
            // 
            this.yara_new_rule_button.Location = new System.Drawing.Point(349, 6);
            this.yara_new_rule_button.Name = "yara_new_rule_button";
            this.yara_new_rule_button.Size = new System.Drawing.Size(77, 25);
            this.yara_new_rule_button.TabIndex = 4;
            this.yara_new_rule_button.Text = "New rule";
            this.yara_new_rule_button.UseVisualStyleBackColor = true;
            this.yara_new_rule_button.Click += new System.EventHandler(this.yara_new_rule_button_Click);
            // 
            // yara_scan_all_processes_binaries_checkbox
            // 
            this.yara_scan_all_processes_binaries_checkbox.AutoSize = true;
            this.yara_scan_all_processes_binaries_checkbox.Location = new System.Drawing.Point(1115, 8);
            this.yara_scan_all_processes_binaries_checkbox.Name = "yara_scan_all_processes_binaries_checkbox";
            this.yara_scan_all_processes_binaries_checkbox.Size = new System.Drawing.Size(194, 21);
            this.yara_scan_all_processes_binaries_checkbox.TabIndex = 17;
            this.yara_scan_all_processes_binaries_checkbox.Text = "Scan all processes (binaries)";
            this.yara_scan_all_processes_binaries_checkbox.UseVisualStyleBackColor = true;
            this.yara_scan_all_processes_binaries_checkbox.CheckedChanged += new System.EventHandler(this.yara_scan_all_processes_binaries_checkbox_CheckedChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SigSearch";
            this.Load += new System.EventHandler(this.Main_Load);
            this.yara_tabcontrol.ResumeLayout(false);
            this.yara_tabcontrol_search_tab.ResumeLayout(false);
            this.yara_tabcontrol_search_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yara_search_results_textbox)).EndInit();
            this.yara_tabcontrol_rule_editor_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.yara_rule_editor_textbox)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl yara_tabcontrol;
        private System.Windows.Forms.TabPage yara_tabcontrol_search_tab;
        private System.Windows.Forms.TabPage yara_tabcontrol_rule_editor_tab;
        public FastColoredTextBoxNS.FastColoredTextBox yara_rule_editor_textbox;
        private System.Windows.Forms.Button yara_save_button;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button yara_delete_rule_button;
        private System.Windows.Forms.Button yara_new_rule_button;
        public System.Windows.Forms.ComboBox yara_selected_rule_combobox;
        private System.Windows.Forms.Button yara_scan_button;
        private System.Windows.Forms.CheckBox yara_search_path_chckbox;
        private System.Windows.Forms.TextBox yara_search_path_textbox;
        private System.Windows.Forms.CheckBox yara_search_proc_chckbox;
        private System.Windows.Forms.TextBox yara_search_proc_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yara_search_args_textbox;
        public FastColoredTextBoxNS.FastColoredTextBox yara_search_results_textbox;
        private System.Windows.Forms.LinkLabel link_label;
        private System.Windows.Forms.CheckBox yara_scan_all_processes_checkbox;
        private System.Windows.Forms.CheckBox yara_scan_all_processes_binaries_checkbox;
    }
}

