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
            this.mdBrowse = new System.Windows.Forms.Button();
            this.mdMerge = new System.Windows.Forms.Button();
            this.mdName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mdPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPage1.Controls.Add(this.mdBrowse);
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
            // mdBrowse
            // 
            this.mdBrowse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdBrowse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.mdBrowse.Location = new System.Drawing.Point(9, 53);
            this.mdBrowse.Name = "mdBrowse";
            this.mdBrowse.Size = new System.Drawing.Size(594, 27);
            this.mdBrowse.TabIndex = 6;
            this.mdBrowse.Text = "Browse Directory...";
            this.mdBrowse.UseVisualStyleBackColor = false;
            this.mdBrowse.Click += new System.EventHandler(this.mdBrowse_Click);
            // 
            // mdMerge
            // 
            this.mdMerge.BackColor = System.Drawing.Color.MediumTurquoise;
            this.mdMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mdMerge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.mdMerge.Location = new System.Drawing.Point(9, 205);
            this.mdMerge.Name = "mdMerge";
            this.mdMerge.Size = new System.Drawing.Size(594, 82);
            this.mdMerge.TabIndex = 5;
            this.mdMerge.Text = "Merge";
            this.mdMerge.UseVisualStyleBackColor = false;
            this.mdMerge.Click += new System.EventHandler(this.mdMerge_Click);
            // 
            // mdName
            // 
            this.mdName.Location = new System.Drawing.Point(9, 154);
            this.mdName.Name = "mdName";
            this.mdName.Size = new System.Drawing.Size(594, 20);
            this.mdName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Directory name:";
            // 
            // mdPath
            // 
            this.mdPath.Location = new System.Drawing.Point(9, 100);
            this.mdPath.Name = "mdPath";
            this.mdPath.Size = new System.Drawing.Size(594, 20);
            this.mdPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parent directory path:";
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
            this.Load += new System.EventHandler(this.OtherTools_Load);
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
        private System.Windows.Forms.Button mdBrowse;
    }
}