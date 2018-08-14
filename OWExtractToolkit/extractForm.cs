using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;

namespace OWExtractToolkit
{
    public partial class extractForm : Form
    {
        SharedCode sc = new SharedCode();
        string filePath;
        string destPath;

        public extractForm(string file, string destination)
        {
            InitializeComponent();
            filePath = sc.downloadsPath + file;
            destPath = sc.dir + destination;
        }

        private void extractForm_Load(object sender, EventArgs e)
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


        }

        public void extract()
        {
            try
            {
                System.IO.Compression.ZipFile.ExtractToDirectory(filePath, destPath);
            }
            catch
            {

            }
            Close();
        }

        public void extractDel()
        {
            extract();
            File.Delete(filePath);
        }


    }

}

