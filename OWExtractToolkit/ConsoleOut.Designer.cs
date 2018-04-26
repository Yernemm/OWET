namespace OWExtractToolkit
{
    partial class ConsoleOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsoleOut));
            this.outputTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdBox = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.topBarMaxim1 = new OWExtractToolkit.TopBarMaxim();
            this.SuspendLayout();
            // 
            // outputTb
            // 
            this.outputTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.outputTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTb.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTb.ForeColor = System.Drawing.Color.Aquamarine;
            this.outputTb.Location = new System.Drawing.Point(12, 118);
            this.outputTb.Multiline = true;
            this.outputTb.Name = "outputTb";
            this.outputTb.ReadOnly = true;
            this.outputTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTb.Size = new System.Drawing.Size(694, 387);
            this.outputTb.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Command Output";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdBox
            // 
            this.cmdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.cmdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdBox.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBox.ForeColor = System.Drawing.Color.Aquamarine;
            this.cmdBox.Location = new System.Drawing.Point(12, 88);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.ReadOnly = true;
            this.cmdBox.Size = new System.Drawing.Size(694, 20);
            this.cmdBox.TabIndex = 5;
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button12.Location = new System.Drawing.Point(12, 511);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(694, 31);
            this.button12.TabIndex = 71;
            this.button12.Text = "Save console log to file";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // topBarMaxim1
            // 
            this.topBarMaxim1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarMaxim1.Location = new System.Drawing.Point(-7, -4);
            this.topBarMaxim1.Name = "topBarMaxim1";
            this.topBarMaxim1.Size = new System.Drawing.Size(731, 36);
            this.topBarMaxim1.TabIndex = 72;
            // 
            // ConsoleOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(718, 553);
            this.Controls.Add(this.topBarMaxim1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsoleOut";
            this.Text = "OW Extract Toolkit - Command Output";
            this.Load += new System.EventHandler(this.ConsoleOut_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cmdBox;
        internal System.Windows.Forms.Button button12;
        private TopBarMaxim topBarMaxim1;
    }
}