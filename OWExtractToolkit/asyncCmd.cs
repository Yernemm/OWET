using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWExtractToolkit.Properties
{
    class asyncCmd
    {
        string dtCmd(string cmd, string dtDir)
        {
            try
            {
                // Start the child process.
                Process p = new Process();
                // Redirect the output stream of the child process.



                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                //startInfo.RedirectStandardInput = true;




                //startInfo.Arguments = ;

                //CHANGE BACK TO DATATOOL.EXE FOR PROPER EXECUTION
                startInfo.FileName = dtDir + @"\DataTool.exe";
                cmd = "--convert-sound=False " + cmd;
                startInfo.Arguments = cmd;

                p.StartInfo = startInfo;
                p.Start();
                //p.StandardInput.WriteLine(dtDir + @"\DataTool.exe " + cmd);
                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                // p.WaitForExit();
                // Read the output stream first and then wait.
                //string output = @"\DataTool.exe " + cmd + "\r\n";

                // p.StandardInput.Flush();
                //p.StandardInput.Close();
                p.WaitForExit();
                string output = p.StandardOutput.ReadToEnd();




                return output;
            }
            catch (Exception ex)
            {
                string exct = "Error running command.\r\nMake sure the correct DataTool path is specified.\r\n\r\nDetails:\r\n" + ex;
                MessageBox.Show(exct);
                return exct;
            }
        }
    }
}
