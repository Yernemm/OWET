using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWExtractToolkit
{
    public partial class TopBar : UserControl
    {

        //------------------------------------------------------------------------------------------------------------------------------------------------
        // This adds the event handler for the control
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.ParentForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                // if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------

        public TopBar()
        {
            this.Load += Loading;
            InitializeComponent();
            AddDrag(backPanel);
            AddDrag(windowText);
            
        }


        private void backPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Loading(object sender, EventArgs e)
        {
            windowText.Text = this.ParentForm.Text;
        }

        private void btnMini_Click_1(object sender, EventArgs e)
        {
            
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }
    }
}
