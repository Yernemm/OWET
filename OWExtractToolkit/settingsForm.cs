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
    public partial class settingsForm : Form
    {
        SharedCode sc = new SharedCode();

        string dir;
        string settPath;
        List<string> defSettings;
        string[] sts;
        public settingsForm()
        {
            InitializeComponent();
        }



        private void settingsForm_Load(object sender, EventArgs e)
        {

            dir = sc.dir;
            defSettings = sc.defSettings;
            settPath = sc.settPath;
            sts = sc.sts;



            //button stuff
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    sc.styleButtons(c);
                }
            }

            //moving oon

            loadSettings();
        }

        //open ow dir
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@sc.sts[0]);
            }
            catch
            {
                MessageBox.Show("Error opening the directory. Make sure it exists.");
            }
        }

        //open output dir
        private void button6_Click(object sender, EventArgs e)
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

        //change ow path
        private void owPathTxt_TextChanged(object sender, EventArgs e)
        {

            checkUnsaved();
        }

        //show unsaved message
        void checkUnsaved()
        {


            // if (owPathTxt.Text != sts[0] || outPathTxt.Text != sts[1] || dtPathTxt.Text != sts[2])
            //   {
            //     unsavedWarning.Show();
            //  }
            //   else
            //   {
            //       unsavedWarning.Hide();
            //   }


            //each(TextBox box in txList)

            List<TextBox> txList = new List<TextBox> { owPathTxt, outPathTxt, dtPathTxt };

            unsavedWarning.Hide();
            for (int i = 0; i < txList.Count; i++)
            {
                if(txList[i].Text != sc.sts[i])
                {
                    unsavedWarning.Show();
                    txList[i].ForeColor = Color.OrangeRed;
                }
                else
                {
                    txList[i].ForeColor = Color.Aquamarine;
                }
            }

            string ch;

            if(radioButton1.Checked == true)
            {
                ch = "0";
            }
            else
            {
                ch = "1";
            }

            if (ch != sc.sts[3])
            {
                unsavedWarning.Show();
                radioButton1.ForeColor = Color.OrangeRed;
                radioButton2.ForeColor = Color.OrangeRed;
            }
            else
            {
                radioButton1.ForeColor = Color.Aquamarine;
                radioButton2.ForeColor = Color.Aquamarine;
            }

        }

        //change outpath dir
        private void outPathTxt_TextChanged(object sender, EventArgs e)
        {

            checkUnsaved();
        }

        //Change datatool dir
        private void dtPathTxt_TextChanged(object sender, EventArgs e)
        {

            checkUnsaved();
        }

        //Open DataTool dir
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@sc.sts[2]);
            }
            catch
            {
                MessageBox.Show("Error opening the directory. Make sure it exists.");
            }
        }
        //Save Button
        void saveSettings()
        {
            sc.sts[0] = owPathTxt.Text;
            sc.sts[1] = outPathTxt.Text;
            sc.sts[2] = dtPathTxt.Text;

            if (radioButton1.Checked == true)
            {
                sc.sts[3] = "0";
            }
            else
            {
                sc.sts[3] = "1";
            }

            try
            {

                File.WriteAllLines(dir + "\\" + "settings.txt", sc.sts);
                checkUnsaved();
                //logOut("default settings.txt created");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR CREATING SETTINGS FILE.\r\nDetails:\r\n" + Convert.ToString(ex));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveSettings();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            owPathTxt.Text = sc.defSettings[0];
            outPathTxt.Text = sc.defSettings[1];
            dtPathTxt.Text = sc.defSettings[2];
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            

        }

        void loadSettings()
        {
            sc.loadSettings();

            try
            {
                owPathTxt.Text = sc.sts[0];
                outPathTxt.Text = sc.sts[1];
                dtPathTxt.Text = sc.sts[2];
                if (sc.sts[3] == "0")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
            }
            catch { };
            checkUnsaved();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadSettings();
            Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Automatic: Data Tool GUI will use the version of Data Tool downloaded by the Toolkit.\r\nCustom: Data Tool GUI will use the version of Data Tool found in the custom folder.");
        }

        public void dlDone()
        {
            extractForm eF = new extractForm("toolchain.zip", @"\DataTool\Automatic");
            eF.Show();
            eF.extractDel();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            string root = sc.dir + @"\DataTool\Automatic";
            if (Directory.Exists(root))
            {
                try
                {  
                    Directory.Delete(root, true);
                } catch(Exception ex)
                {
                    MessageBox.Show("Error deleting old DataTool installation.\r\n\r\nDetails:\r\n" + ex);
                }
            }

            if (!sc.dlToolchain())
            {
            
                MessageBox.Show("Error Downloading Data Tool. Make sure you are connected to the Internet and that you have sufficient storage space.");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            checkUnsaved();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            checkUnsaved();
        }
    }
}
