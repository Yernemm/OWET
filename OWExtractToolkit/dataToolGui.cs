using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace OWExtractToolkit
{
    public partial class dataToolGui : Form
    {



        SharedCode sc = new SharedCode();
        public static string dtDir;
        bool running = false;

        public dataToolGui()
        {
            InitializeComponent();

        }
        
        private void dataToolGui_Load(object sender, EventArgs e)
        {
            sc.loadSettings();
           


            if (sc.sts[3] == "0")
            {
                dtDir = sc.dir + @"\DataTool\Automatic";
            }
            else
            {
                dtDir = sc.sts[2];
            }


            

            int loFi = 0;

            try
            {

                var owVerS = FileVersionInfo.GetVersionInfo(sc.sts[0] + "\\Overwatch.exe");
                String owVer = String.Format("Patch {1}, Build {3}", owVerS.FileMajorPart, owVerS.FileMinorPart,
                                                             owVerS.FileBuildPart, owVerS.FilePrivatePart);
                owVerLabel.Text = owVer;
                //MessageBox.Show(owVer);
            }
            catch
            {
                loFi += 1;
            }

            try
            {

                var dtVerS = FileVersionInfo.GetVersionInfo(dtDir + @"\DataTool.exe");
                String dtVer = String.Format("Patch {1}, Build {3}", dtVerS.FileMajorPart, dtVerS.FileMinorPart,
                                                             dtVerS.FileBuildPart, dtVerS.FilePrivatePart);
                dtVerLabel.Text = dtVer;
            }catch
            {
                loFi += 2;
            }

            string loFiMsg = "";
            switch (loFi)
            {
                case 0:
                    break;

                case 1:
                    loFiMsg = "Overwatch installation not found.";
                    break;

                case 2:
                    loFiMsg = "DataTool not found.";
                    break;

                case 3:
                    loFiMsg = "Overwatch and DataTool not found.";
                    break;


            }
            if(loFiMsg != "")
            {
                MessageBox.Show(loFiMsg + " Make sure your settings are set up properly.");
            }

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    sc.styleButtons(c);
                }
            }

            langBox.SelectedItem = "enUS";

            //Read versions


        }


        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.SForm.Show();
            }

            catch (ObjectDisposedException)
            {
                Form1.SForm = new settingsForm();
                Form1.SForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex) + "            2");

            }
        }
        
        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@sc.sts[1]);
            }
            catch
            {
                MessageBox.Show("Error opening the directory. Make sure it exists.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helpForm hF = new helpForm();
            hF.Show();

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Form1.reloadDT();
        }

        //INITIALISE COMMAND
        string outTXT = "";



        
        String lastCmdOutput = "";
        String lastCmd = "";

        //STEP 1: PREPARE TO RUN THE COMMAND
        void runCmd(string cmdMode, bool useOutput = false)
        {
            if (DataToolProcessExists())
            {
                MessageBox.Show("DataTool.exe process already exists. Make sure DataTool is not running before starting.");

            }
            else
            {
                if (running)
                    return;
                running = true;
                statusLb.Text = "Working...";
                //Application.DoEvents();
                doCmdStuff(cmdMode, useOutput);
            }

        }

        bool useOutputPublic = false;

        //STEP 2: CONSTRUCT EVERYTHING NEEDED FOR COMMAND
        void doCmdStuff(string cmdMode, bool useOutput = false)
        {
            string flags = " " + flagsTxt.Text;
            if (flagsTxt.Text == "")
                flags = flags.Trim();

            //Constructing command.
            string cmd = "-L=" + langBox.Text + flags + " " + "\"" + sc.sts[0] + "\"" + " " + cmdMode;
            if (useOutput)
            {
                cmd += " \"" + sc.sts[1] + "\"";
            }
            cmd += " " + argsTxt.Text;

            useOutputPublic = useOutput;
            dtCmd(cmd);


            //MessageBox.Show(cmd);
            // lastCmdOutput = dtCmd(cmd);
            //  lastCmd = @"DataTool.exe " + cmd.TrimStart();
            //  ConsoleOut co = new ConsoleOut(lastCmdOutput, lastCmd);
            //  co.Show();

            //   if (useOutput)
            //   {
            //       try
            //       {
            //           Process.Start(@sc.sts[1]);
            //       }
            //        catch
            //        {

            //       }
            //  }
        }

        string cmdPublic = "";

        //STEP 3: RUN THE ACTUAL COMMAND
        void dtCmd(string cmd)
        {
            cmdOut = "";
            cmdPublic = cmd;
            using (Process dtp = new Process())
            {
                { // DataTool process configuration
                    dtp.StartInfo.FileName = dtDir + @"\DataTool.exe";
                    dtp.StartInfo.WorkingDirectory = dtDir;
                    dtp.StartInfo.Arguments = cmd;
                    dtp.StartInfo.UseShellExecute = false;
                    dtp.StartInfo.RedirectStandardOutput = true;
                    dtp.StartInfo.RedirectStandardError = true;
                    dtp.StartInfo.StandardOutputEncoding = Encoding.Default;         
                    dtp.StartInfo.StandardErrorEncoding = Encoding.Default;
                    dtp.StartInfo.CreateNoWindow = true;
                }
                try
                {
                    //dtid= dtp.Id;
                    dtp.EnableRaisingEvents = true;
                    dtp.Exited += dtExiting;
                    dtp.Start();
                   
                }
                catch
                {
                    MessageBox.Show("Error running DataTool");
                    return;
                }
                dtp.BeginOutputReadLine();
                dtp.BeginErrorReadLine();
                dtp.OutputDataReceived += new DataReceivedEventHandler(dtReceiveData);
                dtp.ErrorDataReceived += new DataReceivedEventHandler(dtReceiveData);
            }
            dtWatchdog();
        }

        //HANDLE INCOMING DATA WOOSH

        string cmdOut = "";

        void dtReceiveData(object sender, DataReceivedEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Data))
                cmdOut += Encoding.UTF8.GetString(Encoding.Default.GetBytes(e.Data)) + "\r\n";
        }

      private void dtExiting(object sender, EventArgs e)
        {
           // allDone();
        }

        void allDone()
        {
            // MessageBox.Show("done");
         
            lastCmdOutput = cmdOut;
            lastCmd = @"DataTool.exe " + cmdPublic.TrimStart();


            if (useOutputPublic)
            {
                try
                {
                    Process.Start(@sc.sts[1]);
                }
                catch
                {

                }
            }

            showOut();
            SetStatusText("Ready");
            running = false;

        }



        delegate void SetTextCallback(string text);

        private void SetStatusText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.statusLb.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetStatusText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.statusLb.Text = text;
            }
        }


        delegate void openLastCmd();

        //SHOW LAST OUTPUT
        private void showOut()
        {
            if (this.statusLb.InvokeRequired)
            {
                openLastCmd cd = new openLastCmd(showOut);
                this.Invoke(cd, new object[] {  });
            }
            else
            {
                ConsoleOut co = new ConsoleOut(lastCmdOutput, lastCmd);
                co.Show();
            }
            
        }


        //DATATOOL DEADtm WATCHDOG
        private System.Timers.Timer wd;
        void dtWatchdog()
        {
            wd = new System.Timers.Timer(1000);
            wd.Elapsed += OnTimedEvent;
            wd.Start();
        }

        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Process[] pname = Process.GetProcessesByName("DataTool");
            if (pname.Length == 0)
            {
                
                wd.Stop();
                wd.Dispose();
                allDone();
               // MessageBox.Show("nothing");
                

            }
            else { }
               // MessageBox.Show("run");
        }

        bool DataToolProcessExists()
        {
            Process[] pname = Process.GetProcessesByName("DataTool");
            if (pname.Length == 0)
                return false;
            else
                return true;
            // MessageBox.Show("run");
        }






        private void Button10_Click(object sender, EventArgs e)
        {

            runCmd("dump-strings");
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            runCmd("extract-general", true);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            runCmd("list-general-unlocks");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            runCmd("list-heroes");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            runCmd("list-unlocks");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            runCmd("list-lootbox");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            runCmd("list-maps");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            runCmd("list-highlights");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            runCmd("list-subtitles");
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            runCmd("list-subtitles-real");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runCmd("list-chat-replacements");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            runCmd("list-keys");
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            runCmd("extract-unlocks", true);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            runCmd("extract-lootbox", true);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            runCmd("extract-hero-voice", true);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            runCmd("extract-maps", true);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            runCmd("extract-abilities", true);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            runCmd("extract-npcs", true);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            runCmd(customCmd.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            useOutputPublic = false;
            string cmd = customCmd.Text;
            dtCmd(cmd);
            lastCmd = @"DataTool.exe " + cmd.TrimStart();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ConsoleOut co = new ConsoleOut(lastCmdOutput, lastCmd);
            co.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "OWET-CommandOutput.txt";
            save.Filter = "Text File | *.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());

                foreach (var myString in lastCmdOutput.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    writer.WriteLine(myString);
                }

                writer.Dispose();
                writer.Close();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            useOutputPublic = false;
            dtCmd("");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            
             runCmd("list-achievements");
        }




    }
}
