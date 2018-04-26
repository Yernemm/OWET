namespace OWExtractToolkit
{
    partial class OtherTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OtherTools));
            this.topBar1 = new OWExtractToolkit.TopBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mdPath = new System.Windows.Forms.TextBox();
            this.mdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mdMerge = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mdLevel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar1
            // 
            this.topBar1.Location = new System.Drawing.Point(-6, 1);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(650, 34);
            this.topBar1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 424);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.mdLevel);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.mdMerge);
            this.tabPage1.Controls.Add(this.mdName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.mdPath);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.Color.Transparent;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(609, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MergeDir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Merge Directories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parent directory path:";
            // 
            // mdPath
            // 
            this.mdPath.Location = new System.Drawing.Point(9, 72);
            this.mdPath.Name = "mdPath";
            this.mdPath.Size = new System.Drawing.Size(594, 20);
            this.mdPath.TabIndex = 2;
            // 
            // mdName
            // 
            this.mdName.Location = new System.Drawing.Point(9, 126);
            this.mdName.Name = "mdName";
            this.mdName.Size = new System.Drawing.Size(594, 20);
            this.mdName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Directory name:";
            // 
            // mdMerge
            // 
            this.mdMerge.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mdMerge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mdMerge.Location = new System.Drawing.Point(9, 215);
            this.mdMerge.Name = "mdMerge";
            this.mdMerge.Size = new System.Drawing.Size(591, 37);
            this.mdMerge.TabIndex = 5;
            this.mdMerge.Text = "Merge";
            this.mdMerge.UseVisualStyleBackColor = false;
            this.mdMerge.Click += new System.EventHandler(this.mdMerge_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Level of subdirectories:";
            // 
            // mdLevel
            // 
            this.mdLevel.Location = new System.Drawing.Point(9, 175);
            this.mdLevel.Name = "mdLevel";
            this.mdLevel.Size = new System.Drawing.Size(594, 20);
            this.mdLevel.TabIndex = 8;
            this.mdLevel.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Note: \"Level of subdirectories\" does nothing right now. Just keep it at 1.";
            // 
            // OtherTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(641, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.topBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OtherTools";
            this.Text = "OW Extract Toolkit - Other Tools";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TopBar topBar1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox mdName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mdPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mdMerge;
        private System.Windows.Forms.TextBox mdLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}