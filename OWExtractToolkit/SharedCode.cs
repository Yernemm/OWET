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
using System.Xml;

namespace OWExtractToolkit
{
    public class SharedCode
    {
        //Appdata path
        public string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit";
        public string settPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit\settings.txt";
        public string downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit\downloads\";
        public string themesPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit\Themes";
        public string themesSetting = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Yernemm\OWExtractToolkit\theme.setting";
        public string themesDefault = "[default]";
        public List<string> defSettings = new List<string> { "C:\\Program Files (x86)\\Overwatch", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yernemm\\OWExtractToolkit" + "\\output" , Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Yernemm\\OWExtractToolkit" + @"\DataTool\Custom", "0"};
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



        public bool dlToolchainOLD()
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

        public bool dlToolchain()
         
        {
            try
            {
                var webRequest = WebRequest.Create(@"https://ci.appveyor.com/api/projects/yukimono/owlib/branch/tanklib");
                string strContent = "";
                using (var response = webRequest.GetResponse())
                using (var content = response.GetResponseStream())
                using (var reader = new StreamReader(content))
                {
                    strContent = reader.ReadToEnd();
                }
            string[] pcont = strContent.Split('"');
            int counter = 0;
            int valNeed = -1;
            foreach(string a in pcont)
            {
                counter++;
                if (a == "jobId")
                    valNeed = counter + 1;
            }
               
                string actualURL = @"https://ci.appveyor.com/api/buildjobs/" + pcont[valNeed] + @"/artifacts/dist%2Ftoolchain-release.zip";
           // MessageBox.Show(actualURL);
                dlFile(actualURL, "toolchain.zip");


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
                
            }
        }

        public void styleButtons(Control c)
        {
            Theme theme = new Theme();
            Button b = c as Button;
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = theme.getCurrentStyle().buttonBackground.getColor();
            b.ForeColor = theme.getCurrentStyle().buttonText.getColor();
            b.FlatAppearance.BorderColor = theme.getCurrentStyle().buttonBorder.getColor();
            b.FlatAppearance.BorderSize = 1;
        }

       

    }
}
