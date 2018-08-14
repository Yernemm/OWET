namespace OWExtractToolkit
{
    partial class themeSample
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.unsavedWarning = new System.Windows.Forms.Label();
            this.topBarMaxim1 = new OWExtractToolkit.TopBarMaxim();
            this.textBoxUnsaved = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sample Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sample Static Label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sample Dynamic Label";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Sample Input Textbox";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(341, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Sample Read-Only Textbox";
            // 
            // unsavedWarning
            // 
            this.unsavedWarning.AutoSize = true;
            this.unsavedWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unsavedWarning.Location = new System.Drawing.Point(12, 299);
            this.unsavedWarning.Name = "unsavedWarning";
            this.unsavedWarning.Size = new System.Drawing.Size(251, 18);
            this.unsavedWarning.TabIndex = 6;
            this.unsavedWarning.Text = "Unsaved Settings Warning Label";
            // 
            // topBarMaxim1
            // 
            this.topBarMaxim1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarMaxim1.Location = new System.Drawing.Point(-2, -2);
            this.topBarMaxim1.Name = "topBarMaxim1";
            this.topBarMaxim1.Size = new System.Drawing.Size(368, 36);
            this.topBarMaxim1.TabIndex = 7;
            // 
            // textBoxUnsaved
            // 
            this.textBoxUnsaved.Location = new System.Drawing.Point(12, 240);
            this.textBoxUnsaved.Name = "textBoxUnsaved";
            this.textBoxUnsaved.Size = new System.Drawing.Size(341, 20);
            this.textBoxUnsaved.TabIndex = 8;
            this.textBoxUnsaved.Text = "Unsaved Changes Textbox";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sample Large Static Label";
            // 
            // themeSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUnsaved);
            this.Controls.Add(this.topBarMaxim1);
            this.Controls.Add(this.unsavedWarning);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "themeSample";
            this.Text = "OWET Theme Sample";
            this.Load += new System.EventHandler(this.themeSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label unsavedWarning;
        private TopBarMaxim topBarMaxim1;
        private System.Windows.Forms.TextBox textBoxUnsaved;
        private System.Windows.Forms.Label label3;
    }
}