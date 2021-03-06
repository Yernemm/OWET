﻿namespace OWExtractToolkit
{
    partial class settingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.owPathTxt = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.outPathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unsavedWarning = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.dtPathTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listThemes = new System.Windows.Forms.ListBox();
            this.btThemesApply = new System.Windows.Forms.Button();
            this.btThemesOpen = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.checkBoxUpdateCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdateDownload = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.topBar1 = new OWExtractToolkit.TopBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save and close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(365, 476);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reset to Default";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(8, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(469, 23);
            this.label12.TabIndex = 83;
            this.label12.Text = "Overwatch Path:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // owPathTxt
            // 
            this.owPathTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.owPathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.owPathTxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.owPathTxt.Location = new System.Drawing.Point(11, 221);
            this.owPathTxt.Name = "owPathTxt";
            this.owPathTxt.Size = new System.Drawing.Size(415, 20);
            this.owPathTxt.TabIndex = 84;
            this.owPathTxt.TextChanged += new System.EventHandler(this.owPathTxt_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(432, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 25);
            this.button5.TabIndex = 85;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(432, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 25);
            this.button6.TabIndex = 88;
            this.button6.Text = "Open";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // outPathTxt
            // 
            this.outPathTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.outPathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outPathTxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.outPathTxt.Location = new System.Drawing.Point(11, 278);
            this.outPathTxt.Name = "outPathTxt";
            this.outPathTxt.Size = new System.Drawing.Size(415, 20);
            this.outPathTxt.TabIndex = 87;
            this.outPathTxt.TextChanged += new System.EventHandler(this.outPathTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(8, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 23);
            this.label1.TabIndex = 86;
            this.label1.Text = "Output Folder Path:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 23);
            this.label2.TabIndex = 89;
            this.label2.Text = "Data Tool GUI Settings:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unsavedWarning
            // 
            this.unsavedWarning.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsavedWarning.ForeColor = System.Drawing.Color.OrangeRed;
            this.unsavedWarning.Location = new System.Drawing.Point(7, 450);
            this.unsavedWarning.Name = "unsavedWarning";
            this.unsavedWarning.Size = new System.Drawing.Size(469, 23);
            this.unsavedWarning.TabIndex = 90;
            this.unsavedWarning.Text = "WARNING: Some settings are not saved.";
            this.unsavedWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(432, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 25);
            this.button7.TabIndex = 93;
            this.button7.Text = "Open";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dtPathTxt
            // 
            this.dtPathTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.dtPathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtPathTxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.dtPathTxt.Location = new System.Drawing.Point(11, 334);
            this.dtPathTxt.Name = "dtPathTxt";
            this.dtPathTxt.Size = new System.Drawing.Size(415, 20);
            this.dtPathTxt.TabIndex = 92;
            this.dtPathTxt.TextChanged += new System.EventHandler(this.dtPathTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(8, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 23);
            this.label3.TabIndex = 91;
            this.label3.Text = "Custom DataTool Path:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(11, 422);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(462, 25);
            this.button8.TabIndex = 94;
            this.button8.Text = "Download Latest DataTool";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(8, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "DataTool Build:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.radioButton1.ForeColor = System.Drawing.Color.Aquamarine;
            this.radioButton1.Location = new System.Drawing.Point(14, 385);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 19);
            this.radioButton1.TabIndex = 96;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Automatic";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic);
            this.radioButton2.ForeColor = System.Drawing.Color.Aquamarine;
            this.radioButton2.Location = new System.Drawing.Point(226, 385);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 19);
            this.radioButton2.TabIndex = 97;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Custom";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(432, 379);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 25);
            this.button9.TabIndex = 98;
            this.button9.Text = "?";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(508, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 23);
            this.label5.TabIndex = 100;
            this.label5.Text = "Themes:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listThemes
            // 
            this.listThemes.FormattingEnabled = true;
            this.listThemes.Location = new System.Drawing.Point(511, 88);
            this.listThemes.Name = "listThemes";
            this.listThemes.Size = new System.Drawing.Size(308, 342);
            this.listThemes.TabIndex = 101;
            // 
            // btThemesApply
            // 
            this.btThemesApply.Location = new System.Drawing.Point(511, 447);
            this.btThemesApply.Name = "btThemesApply";
            this.btThemesApply.Size = new System.Drawing.Size(148, 25);
            this.btThemesApply.TabIndex = 103;
            this.btThemesApply.Text = "Apply Theme";
            this.btThemesApply.UseVisualStyleBackColor = true;
            this.btThemesApply.Click += new System.EventHandler(this.btThemesApply_Click);
            // 
            // btThemesOpen
            // 
            this.btThemesOpen.Location = new System.Drawing.Point(511, 476);
            this.btThemesOpen.Name = "btThemesOpen";
            this.btThemesOpen.Size = new System.Drawing.Size(308, 25);
            this.btThemesOpen.TabIndex = 104;
            this.btThemesOpen.Text = "Open Themes Folder";
            this.btThemesOpen.UseVisualStyleBackColor = true;
            this.btThemesOpen.Click += new System.EventHandler(this.btThemesOpen_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(671, 447);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(148, 25);
            this.button10.TabIndex = 105;
            this.button10.Text = "Preview Theme";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // checkBoxUpdateCheck
            // 
            this.checkBoxUpdateCheck.AutoSize = true;
            this.checkBoxUpdateCheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxUpdateCheck.Location = new System.Drawing.Point(14, 88);
            this.checkBoxUpdateCheck.Name = "checkBoxUpdateCheck";
            this.checkBoxUpdateCheck.Size = new System.Drawing.Size(213, 17);
            this.checkBoxUpdateCheck.TabIndex = 106;
            this.checkBoxUpdateCheck.Text = "Automatically check for OWET updates";
            this.checkBoxUpdateCheck.UseVisualStyleBackColor = true;
            this.checkBoxUpdateCheck.CheckedChanged += new System.EventHandler(this.checkBoxUpdateCheck_CheckedChanged);
            // 
            // checkBoxUpdateDownload
            // 
            this.checkBoxUpdateDownload.AutoSize = true;
            this.checkBoxUpdateDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxUpdateDownload.Location = new System.Drawing.Point(14, 111);
            this.checkBoxUpdateDownload.Name = "checkBoxUpdateDownload";
            this.checkBoxUpdateDownload.Size = new System.Drawing.Size(228, 17);
            this.checkBoxUpdateDownload.TabIndex = 107;
            this.checkBoxUpdateDownload.Text = "Automatically download and install updates";
            this.checkBoxUpdateDownload.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(11, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(469, 23);
            this.label7.TabIndex = 109;
            this.label7.Text = "OWET Settings:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topBar1
            // 
            this.topBar1.Location = new System.Drawing.Point(-2, -2);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(843, 34);
            this.topBar1.TabIndex = 99;
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 517);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxUpdateDownload);
            this.Controls.Add(this.checkBoxUpdateCheck);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btThemesOpen);
            this.Controls.Add(this.btThemesApply);
            this.Controls.Add(this.listThemes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dtPathTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unsavedWarning);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.outPathTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.owPathTxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settingsForm";
            this.Text = "OW Extract Toolkit - Settings";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox owPathTxt;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox outPathTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label unsavedWarning;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox dtPathTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button9;
        private TopBar topBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listThemes;
        private System.Windows.Forms.Button btThemesApply;
        private System.Windows.Forms.Button btThemesOpen;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.CheckBox checkBoxUpdateCheck;
        private System.Windows.Forms.CheckBox checkBoxUpdateDownload;
        private System.Windows.Forms.Label label7;
    }
}