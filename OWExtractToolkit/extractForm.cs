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

