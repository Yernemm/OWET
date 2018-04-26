namespace OWExtractToolkit
{
    partial class convertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(convertForm));
            this.label3 = new System.Windows.Forms.Label();
            this.conPathTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.outputTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.fBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.topBar1 = new OWExtractToolkit.TopBar();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Black", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 62);
            this.label3.TabIndex = 4;
            this.label3.Text = "Convert Tools";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conPathTxt
            // 
            this.conPathTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.conPathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conPathTxt.ForeColor = System.Drawing.Color.Aquamarine;
            this.conPathTxt.Location = new System.Drawing.Point(12, 121);
            this.conPathTxt.Name = "conPathTxt";
            this.conPathTxt.Size = new System.Drawing.Size(424, 20);
            this.conPathTxt.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(12, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(424, 23);
            this.label12.TabIndex = 86;
            this.label12.Text = "Conversion Folder Path:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 147);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 25);
            this.button5.TabIndex = 87;
            this.button5.Text = "Browse...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // outputTb
            // 
            this.outputTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.outputTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTb.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTb.ForeColor = System.Drawing.Color.Aquamarine;
            this.outputTb.Location = new System.Drawing.Point(15, 178);
            this.outputTb.Multiline = true;
            this.outputTb.Name = "outputTb";
            this.outputTb.ReadOnly = true;
            this.outputTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTb.Size = new System.Drawing.Size(421, 213);
            this.outputTb.TabIndex = 88;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 25);
            this.button1.TabIndex = 89;
            this.button1.Text = "Convert .wem to .ogg";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.Location = new System.Drawing.Point(19, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 25);
            this.button2.TabIndex = 90;
            this.button2.Text = "Download .wem to .ogg conversion package";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // topBar1
            // 
            this.topBar1.Location = new System.Drawing.Point(-3, 0);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(457, 34);
            this.topBar1.TabIndex = 91;
            // 
            // convertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(448, 521);
            this.Controls.Add(this.topBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outputTb);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.conPathTxt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "convertForm";
            this.Text = "OW Extract Toolkit - Convert Tools";
            this.Load += new System.EventHandler(this.convertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox conPathTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox outputTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FolderBrowserDialog fBrowser;
        private TopBar topBar1;
    }
}