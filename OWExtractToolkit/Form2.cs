using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWExtractToolkit
{
    public partial class Form2 : Form
    {
        SharedCode sc = new SharedCode();
        string dlPath;
        string fileName;
        public Form2(String dlP, String fNm)
        {
            InitializeComponent();
            dlPath = dlP;
            fileName = fNm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Style Form Theme
            Theme theme = new Theme();
            Style st = theme.getCurrentStyle();
            foreach (Control c in this.Controls)
            {
                styleControl(c);
            }



            void styleControl(Control c)
            {
                if (c is Button)
                {
                    sc.styleButtons(c);
                }

                if (c is Label)
                {
                    c.ForeColor = theme.getCurrentStyle().labelStatic.getColor();
                }

                if (c is TextBox)
                {
                    if (((TextBox)c).ReadOnly)
                    {
                        c.BackColor = theme.getCurrentStyle().textBoxReadOnlyBackground.getColor();
                        c.ForeColor = theme.getCurrentStyle().textBoxReadOnlyText.getColor();
                    }
                    else
                    {
                        c.BackColor = theme.getCurrentStyle().textBoxInputBackground.getColor();
                        c.ForeColor = theme.getCurrentStyle().textBoxInputText.getColor();
                    }
                }

                if (c is ComboBox)
                {
                    c.BackColor = theme.getCurrentStyle().textBoxInputBackground.getColor();
                    c.ForeColor = theme.getCurrentStyle().textBoxInputText.getColor();
                }
            }
            this.BackColor = theme.getCurrentStyle().background.getColor();

            //
            label1.Text = fileName;
            startDownload();
        }

        void styleButtons(Control c)
        {
            Button b = c as Button;
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = Color.OrangeRed;
            b.ForeColor = Color.Aqua;
            b.FlatAppearance.BorderColor = Color.Orange;
            b.FlatAppearance.BorderSize = 1;
        }

        private void startDownload()
        {
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadFileAsync(new Uri(@dlPath), @sc.downloadsPath + fileName);
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            label4.Text = e.BytesReceived + "B / " + e.TotalBytesToReceive + "B";
            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //label2.Text = "Completed";

            if (fileName == "toolchain.zip")
            {
                Form1.SForm.dlDone();
            }
            else if (fileName == "pack-audio.zip")
            {
                Form1.CForm.dlDone();
            }

            Close();
        }

    }
}
