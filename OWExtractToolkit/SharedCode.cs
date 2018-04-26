using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace OWExtractToolkit
{
    public class SharedCode
    {
        //Appdata path
        public string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit";
        public string settPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit\settings.txt";
        public string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit\downloads\";
        public List<string> defSettings = new List<string> { "C:\\Program Files (x86)\\Overwatch", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yernemm\\OWExtractToolkit" + "\\output" , Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yernemm\\OWExtractToolkit" + @"\DataTool\Custom", "0" };
        public string[] sts;
        public void loadSettings()
        {
            try
            {
                sts = File.ReadAllLines(settPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR READING SETTINGS FILE.\r\nConsider deleting the Yernemm\\OWExtractToolkit directory from AppData\\roaming and restart the Toolkit. \r\n----------------------------\r\nDETAILS: \r\n" + ex);
            }

        }
        Form2 f2;
        public bool dlFile(string URL, string name)
        {
            try
            {
                f2 = new Form2(URL, name);
                f2.Show();
                return true;
            }
            catch
            {
                return false;
            }

        
           
        }



        public bool dlToolchain()
        {
            try
            {
                var webRequest = WebRequest.Create(@"https://yernemm.xyz/programs/OWExtractToolkit/datatool.txt");
                string strContent = "";
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    strContent = reader.ReadToEnd();
                }
                dlFile(strContent, "toolchain.zip");


                return true;
            }
            catch
            {
                return false;
            }
        }

        public void styleButtons(Control c)
        {
            Button b = c as Button;
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = Color.OrangeRed;
            b.ForeColor = Color.Aqua;
            b.FlatAppearance.BorderColor = Color.Orange;
            b.FlatAppearance.BorderSize = 1;
        }

       

    }
}
