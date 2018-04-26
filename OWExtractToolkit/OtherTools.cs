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
        public OtherTools()
        {
            InitializeComponent();
        }

        private void mdMerge_Click(object sender, EventArgs e)
        {
            string path = mdPath.Text;
            string dir = mdName.Text;
            int levels;
            if(int.TryParse(mdLevel.Text, out levels))
            {
                if(levels > 0)
                {
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
                else
                {
                    MessageBox.Show("Enter a valid integer level of 1 or above.");
                }              
            }
            else
            {
                MessageBox.Show("Enter a valid integer level of 1 or above.");
            }
        }
    }
}
