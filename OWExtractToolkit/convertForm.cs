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

namespace OWExtractToolkit
{
    public partial class convertForm : Form
    {
        SharedCode sc = new SharedCode();
        public convertForm()
        {
            InitializeComponent();
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
        }

        private void convertForm_Load(object sender, EventArgs e)
        {

            //button stuff
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    sc.styleButtons(c);
                }
            }

            //moving oon
        }

        public void dlDone()
        {
            extractForm eF = new extractForm("pack-audio.zip", @"\Packages\wem-ogg");
            eF.Show();
            eF.extractDel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string root = sc.dir + @"\Packages\wem-ogg";
            if (Directory.Exists(root))
            {
                try
                {
                    Directory.Delete(root, true);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting old package.\r\n\r\nDetails:\r\n" + ex);
                }
            }

            if (!sc.dlFile(@"https://yernemm.xyz/programs/OWExtractToolkit/packages/owet-convert-wem-ogg-pack.zip", "pack-audio.zip"))
            {

                MessageBox.Show("Error Downloading Package. Make sure you are connected to the Internet and that you have sufficient storage space.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            string path = conPathTxt.Text;
            if (!System.IO.Directory.Exists(path))
            {
                MessageBox.Show("Invalid folder path.");
            }
            else
            {
                //original path
                string opath = sc.dir + @"\Packages\wem-ogg";
                File.Copy(opath + "\\packed_codebooks_aoTuV_603.bin", path + "\\packed_codebooks_aoTuV_603.bin", true);
                File.Copy(opath + "\\revorb.exe", path + "\\revorb.exe", true);
                File.Copy(opath + "\\ww2ogg.exe", path + "\\ww2ogg.exe", true);
                File.Copy(opath + "\\script.bat", path + "\\script.bat", true);



                for (int i = 0; (i <= 1); i++)
                {
                    if ((i == 0))
                    {
                        writeToConsole(@"Converting...");
                    }
                    else
                    {

                        backgroundWorker1.RunWorkerAsync();


                    }
                }
            }
            
        }

        private void writeToConsole(string v)
        {
            outputTb.Text += v + "\r\n";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string path = conPathTxt.Text;
            ProcessStartInfo proc = new ProcessStartInfo("cmd.exe");
            Process pr;
            proc.CreateNoWindow = true;
            proc.UseShellExecute = false;
            proc.RedirectStandardInput = true;
            proc.RedirectStandardOutput = true;
            pr = Process.Start(proc);
            pr.StandardInput.WriteLine(("cd " + path));
            pr.StandardInput.WriteLine("script.bat");
            pr.StandardInput.Close();
            string result = pr.StandardOutput.ReadToEnd();
            pr.StandardOutput.Close();
            e.Result = result;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //  First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                //  Next, handle the case where the user canceled the 
                //  operation.
                //  Note that due to a race condition in 
                //  the DoWork event handler, the Cancelled
                //  flag may not have been set, even though
                //  CancelAsync was called.
                outputTb.Text = "Cancelled";
            }
            else
            {
                //  Finally, handle the case where the operation succeeded.
                outputTb.Text = e.Result.ToString();
                // cleanup
                string path = conPathTxt.Text;
                //My.Computer.FileSystem.DeleteFile((path + "\\packed_codebooks_aoTuV_603.bin"), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently);
               // My.Computer.FileSystem.DeleteFile((path + "\\revorb.exe"), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently);
               // My.Computer.FileSystem.DeleteFile((path + "\\ww2ogg.exe"), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently);
               // My.Computer.FileSystem.DeleteFile((path + "\\script.bat"), FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently);
                File.Delete(path + "\\packed_codebooks_aoTuV_603.bin");
                File.Delete(path + "\\revorb.exe");
                File.Delete(path + "\\ww2ogg.exe");
                File.Delete(path + "\\script.bat");
            }
            this.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sc.loadSettings();
            fBrowser.SelectedPath = sc.sts[1];
            if (fBrowser.ShowDialog() == DialogResult.OK)
            {
                conPathTxt.Text = fBrowser.SelectedPath;

           }
        }
    }
}

