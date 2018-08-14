using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWExtractToolkit
{
    public partial class OtherTools : Form
    {
        public SharedCode sc = new SharedCode();
        public OtherTools()
        {
            InitializeComponent();
        }

        private void mdMerge_Click(object sender, EventArgs e)
        {
            string path = mdPath.Text;
            string dir = mdName.Text;

                    MessageBox.Show(path + "\\" + dir + "\\");
                    Directory.CreateDirectory(path + "\\" + dir);
                    
                   string[] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
                    foreach (string subdir in dirs)
                    {
                        if (subdir.EndsWith(dir))
                        {
                            string[] files = Directory.GetFiles(subdir);
                            foreach(string file in files)
                            {
                                string[] fileSplit = file.Split(@"\"[0]);
                                try
                                {
                                    File.Copy(file, Path.Combine(path, dir, fileSplit[fileSplit.Length - 1]), false);
                                }catch
                                { }
                                //path + "\\" + dir + "\\" + fileSplit[fileSplit.Length - 1]
                            }
                        }
                    }
             

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mdBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = sc.dir + @"\output";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    mdPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void OtherTools_Load(object sender, EventArgs e)
        {
            //Style Form
            Theme theme = new Theme();
            foreach (Control c in this.Controls)
            {
                styleControl(c);
            }

            foreach (TabPage t in tabControl1.TabPages)
            {
                foreach (Control c in t.Controls)
                {
                    styleControl(c);
                }
                t.BackColor = theme.getCurrentStyle().background.getColor();
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
            }
            this.BackColor = theme.getCurrentStyle().background.getColor();
            //
        }
    }
}
