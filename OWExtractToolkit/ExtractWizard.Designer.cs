namespace OWExtractToolkit
{
    partial class ExtractWizard
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
            this.topBar1 = new OWExtractToolkit.TopBar();
            this.mainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainBox = new System.Windows.Forms.TextBox();
            this.mainListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // topBar1
            // 
            this.topBar1.Location = new System.Drawing.Point(-5, -3);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(858, 38);
            this.topBar1.TabIndex = 0;
            // 
            // mainFlowPanel
            // 
            this.mainFlowPanel.AutoScroll = true;
            this.mainFlowPanel.Location = new System.Drawing.Point(12, 108);
            this.mainFlowPanel.Name = "mainFlowPanel";
            this.mainFlowPanel.Size = new System.Drawing.Size(632, 395);
            this.mainFlowPanel.TabIndex = 1;
            // 
            // mainBox
            // 
            this.mainBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.mainBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mainBox.Location = new System.Drawing.Point(13, 42);
            this.mainBox.Multiline = true;
            this.mainBox.Name = "mainBox";
            this.mainBox.ReadOnly = true;
            this.mainBox.Size = new System.Drawing.Size(821, 60);
            this.mainBox.TabIndex = 2;
            // 
            // mainListBox
            // 
            this.mainListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.mainListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mainListBox.FormattingEnabled = true;
            this.mainListBox.HorizontalScrollbar = true;
            this.mainListBox.Location = new System.Drawing.Point(651, 109);
            this.mainListBox.Name = "mainListBox";
            this.mainListBox.Size = new System.Drawing.Size(183, 392);
            this.mainListBox.TabIndex = 3;
            // 
            // ExtractWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(846, 515);
            this.Controls.Add(this.mainListBox);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.mainFlowPanel);
            this.Controls.Add(this.topBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtractWizard";
            this.Text = "OW Extract Toolkit - Extraction Wizard";
            this.Load += new System.EventHandler(this.ExtractWizard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TopBar topBar1;
        private System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        private System.Windows.Forms.TextBox mainBox;
        private System.Windows.Forms.ListBox mainListBox;
    }
}