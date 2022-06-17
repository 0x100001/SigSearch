namespace SigSearch.YARA.Add_New_Rule
{
    partial class Add_New_Rule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Rule));
            this.yara_rule_editor_textbox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.yara_save_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yara_rule_name_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.yara_rule_editor_textbox)).BeginInit();
            this.SuspendLayout();
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
            this.yara_rule_editor_textbox.AutoScrollMinSize = new System.Drawing.Size(483, 210);
            this.yara_rule_editor_textbox.BackBrush = null;
            this.yara_rule_editor_textbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.yara_rule_editor_textbox.Location = new System.Drawing.Point(12, 42);
            this.yara_rule_editor_textbox.Name = "yara_rule_editor_textbox";
            this.yara_rule_editor_textbox.Paddings = new System.Windows.Forms.Padding(0);
            this.yara_rule_editor_textbox.RightBracket = ')';
            this.yara_rule_editor_textbox.RightBracket2 = '}';
            this.yara_rule_editor_textbox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(182)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.yara_rule_editor_textbox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("yara_rule_editor_textbox.ServiceColors")));
            this.yara_rule_editor_textbox.ShowCaretWhenInactive = true;
            this.yara_rule_editor_textbox.ShowFoldingLines = true;
            this.yara_rule_editor_textbox.Size = new System.Drawing.Size(1326, 646);
            this.yara_rule_editor_textbox.TabIndex = 2;
            this.yara_rule_editor_textbox.Text = resources.GetString("yara_rule_editor_textbox.Text");
            this.yara_rule_editor_textbox.WordWrapAutoIndent = false;
            this.yara_rule_editor_textbox.Zoom = 100;
            // 
            // yara_save_button
            // 
            this.yara_save_button.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yara_save_button.Location = new System.Drawing.Point(12, 694);
            this.yara_save_button.Name = "yara_save_button";
            this.yara_save_button.Size = new System.Drawing.Size(1326, 23);
            this.yara_save_button.TabIndex = 4;
            this.yara_save_button.Text = "Save rule";
            this.yara_save_button.UseVisualStyleBackColor = true;
            this.yara_save_button.Click += new System.EventHandler(this.yara_save_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rule name:";
            // 
            // yara_rule_name_textbox
            // 
            this.yara_rule_name_textbox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.yara_rule_name_textbox.Location = new System.Drawing.Point(93, 6);
            this.yara_rule_name_textbox.Name = "yara_rule_name_textbox";
            this.yara_rule_name_textbox.Size = new System.Drawing.Size(224, 25);
            this.yara_rule_name_textbox.TabIndex = 6;
            // 
            // Add_New_Rule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.yara_rule_name_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yara_save_button);
            this.Controls.Add(this.yara_rule_editor_textbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_New_Rule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new rule";
            this.Load += new System.EventHandler(this.Add_New_Rule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yara_rule_editor_textbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public FastColoredTextBoxNS.FastColoredTextBox yara_rule_editor_textbox;
        private System.Windows.Forms.Button yara_save_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yara_rule_name_textbox;
    }
}