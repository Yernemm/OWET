using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace OWExtractToolkit
{



    
    public partial class Form1 : Form
    {


        public SharedCode sc = new SharedCode();

        static Random rnd = new Random();
        List<string> subMsg = new List<string> { "For all of your extracting needs!", "Extract images, sounds, textures and more!", "For when you need to get some Overwatch files!", "You can extract and listen to your favourite voice lines!", "You can extract your favourite sprays!", "You can extract and animate character models!","You can convert extracted files to usable files!", "The tools you need to look inside Overwatch!" };
        string dir;
        List<string> defSettings;

        public Form1()
        {
            
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //theme sampling for debugging stuff

            //themeSample ttt = new themeSample();
            //ttt.Show();
          


            //Setting up version

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;

            label2.Text = "OWET Version " + version + @" By Yernemm: https://yernemm.xyz";





            //SETTING UP STRACKER


            webB.Hide();
            webB.Width = 1080;
            webB.Height = 1920;
            webB.Url = new Uri($"https://yernemm.xyz/stracker?s=OWET-v{version}");


            //CHECK FOR UPDATES

            //old method below

            //try
            //{
            //    var webRequest = WebRequest.Create(@"https://yernemm.xyz/programs/OWExtractToolkit/version.txt");
            //    string latestVer = "";
            //    using (var response = webRequest.GetResponse())
            //    using (var content = response.GetResponseStream())
            //    using (var reader = new StreamReader(content))
            //    {
            //        latestVer = reader.ReadToEnd();
            //    }

            //    if (version != latestVer)
            //        MessageBox.Show(@"New update found. Visit https://yernemm.xyz to download.");

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error connecting to webserver.\r\n\r\n" + ex);
            //}

            if (sc.checkForOwetUpdate())
            {
                MessageBox.Show(@"New update found. Visit https://yernemm.xyz to download.");
            }

            //---------------------------

            dir = sc.dir;
            defSettings = sc.defSettings;


            //Setting up form...
            Theme theme = new Theme();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    sc.styleButtons(c);
                }

                if(c is Label)
                {
                    c.ForeColor = theme.getCurrentStyle().labelStatic.getColor();
                }

                if(c is TextBox)
                {
                    if( ((TextBox)c).ReadOnly)
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


            int r = rnd.Next(subMsg.Count);
            subText.Text = subMsg[r];

            //HIDING CONVERSION TOOOLS
          //  button2.BackColor = Color.Gray;
          //  button2.ForeColor = Color.Black;
          //  button2.FlatAppearance.BorderColor = Color.DarkSlateGray;




           








            //-----------
            //MessageBox.Show(dir);

            logTxt.Text = "";
            //lbStatus.Text = "Setting up basic directories...";
            if (!Directory.Exists(dir))
            {
                logTxt.Text += "Setting up basic directories..." + "\r\n";
                createDir("");
                
                // Directory.CreateDirectory(dir);
                //File.Create(dir + "\\settings.txt");
                // logTxt.Text += "Basic directories set up." + "\r\n";
            }
            else
            {
                //logTxt.Hide();
            }
            
            if (!File.Exists(dir + "\\" + "settings.txt"))
            {
                
               // createFile("settings.txt");
                    try
                    {
                    
                        File.WriteAllLines(dir + "\\" + "settings.txt", defSettings);
                    logOut("default settings.txt created");
                } catch (Exception ex)
                    {
                    logOut("ERROR CREATING SETTINGS FILE.");
                    logOut(Convert.ToString(ex));
                    }
               
            }

            createDir(@"DataTool\Custom");
            createDir("downloads");
            createDir("output");
            createDir(@"\Packages\wem-ogg");
            createDir(@"Themes");
            createDir(@"owet");

            //Create all default theme files

            createFileContents("Themes Readme", sc.themesPath + @"\README.txt", @"To make your own theme, duplicate sample.owett and open it with a text editor.
More info about the syntax is in sample.owett");
            createFileContents("Light Theme", sc.themesPath + @"\light.owett", theme.coreThemeText("light"));
            createFileContents("Light Grey Theme", sc.themesPath + @"\lightGrey.owett", theme.coreThemeText("lightGrey"));
            createFileContents("Sample Theme", sc.themesPath + @"\sample.owett", theme.coreThemeText("sample"));
            createFileContents("Dark Theme", sc.themesPath + @"\dark.owett", theme.coreThemeText("dark"));
            createFileContents("Themes Setting", sc.themesSetting, sc.themesDefault);
            createFileContents("Updater Setting", sc.updaterSetting, sc.updaterDefault);

        }
        void logOut(string line)
        {
            logTxt.Text += line + "\r\n";
        }
        void createFileContents(string name, string path, string contents)
        {
            if (!File.Exists(path))
            {

                // createFile("settings.txt");
                try
                {

                    File.WriteAllText(path, contents);
                    logOut("File " + name + " created.");
                }
                catch (Exception ex)
                {
                    logOut("ERROR CREATING "+name+" FILE.");
                    logOut(Convert.ToString(ex));
                }

            }
        }
        void createFile(string path)
        {
            if (!File.Exists(dir + "\\" + path))
            {
                File.Create(dir + "\\" + path);
                logOut(path + " file created.");
            }
        }
        void createDir(string path)
        {
            if (!Directory.Exists(dir + "\\" + path))
            {
                Directory.CreateDirectory(dir + "\\" + path);
                logOut(dir + "\\" + path + " directory created.");
            }
        }


        private void Form1_FormClosing(Object sender, FormClosingEventArgs e)
            {
            if (!CForm.Enabled || !DTForm.Enabled)
            {
                var window = MessageBox.Show(
            "OWET is currently running a command. Closing the main window will cause the entire program to close, possibly corrupting any files it is working on. Are you sure you want to quit?",
            "Quit?",
            MessageBoxButtons.YesNo);

                e.Cancel = (window == DialogResult.No);
            }
        }

        //OPEN DATA TOOL GUI
        public static dataToolGui DTForm = new dataToolGui();
        private void button1_Click(object sender, EventArgs e)
        {
            //DTForm = new dataToolGui();
            //DTForm.Show();


            try
            {
                DTForm.Show();
            }

            catch (ObjectDisposedException)
            {
                DTForm = new dataToolGui();
                DTForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex) + "            2");

            }

        }

        public static void reloadDT()
        {
            DTForm.Close();
            DTForm = new dataToolGui();
            DTForm.Show();
        }



        //OPEN SETTINGS
        public static settingsForm SForm = new settingsForm();

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SForm.Show();
            }

            catch(ObjectDisposedException)
            {
                SForm = new settingsForm();
                SForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex) + "            2");

            }
        }

        public static convertForm CForm = new convertForm();
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CForm.Show();
            }

            catch (ObjectDisposedException)
            {
                CForm = new convertForm();
                CForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex) + "            2");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helpForm hF = new helpForm();
            hF.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yernemm.xyz/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yernemm.xyz/projects/owet");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yernemm.xyz/projects/owet");
        }

        public static OtherTools OTForm = new OtherTools();
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OTForm.Show();
            }

            catch (ObjectDisposedException)
            {
                OTForm = new OtherTools();
                OTForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex) + "            2");

            }
        }

        public static ExtractWizard exWizard = new ExtractWizard();
        private void button6_Click(object sender, EventArgs e)
        {
            


            try
            {
                exWizard.Show();
            }

            catch (ObjectDisposedException)
            {
                exWizard = new ExtractWizard();
                exWizard.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex) + "            2");

            }
        }
    }
}
