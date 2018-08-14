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
    public partial class TopBarMaxim : UserControl
    {

        //Themes
        Theme theme = new Theme();










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
                 if (this.ParentForm.Location.Y == 0) { this.ParentForm.WindowState = FormWindowState.Maximized; }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------


        public TopBarMaxim()
        {
            this.Load += Loading;
            InitializeComponent();
            AddDrag(backPanel);
            AddDrag(windowText);
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
        }


        private void Loading(object sender, EventArgs e)
        {
            windowText.Text = this.ParentForm.Text;

           
            
            backPanel.BackColor = theme.getCurrentStyle().topBarBackground.getColor();
            windowText.ForeColor = theme.getCurrentStyle().topBarText.getColor();
            btnMini.BackColor = theme.getCurrentStyle().topBarBackground.getColor();
            btnMini.ForeColor = theme.getCurrentStyle().topBarButtonMin.getColor();
            btnClose.BackColor = theme.getCurrentStyle().topBarBackground.getColor();
            btnClose.ForeColor = theme.getCurrentStyle().topBarButtonClose.getColor();
            btnMax.BackColor = theme.getCurrentStyle().topBarBackground.getColor();
            btnMax.ForeColor = theme.getCurrentStyle().topBarButtonMax.getColor();
        }

        public void setTheme(Style style)
        {
            backPanel.BackColor = style.topBarBackground.getColor();
            windowText.ForeColor = style.topBarText.getColor();
            btnMini.BackColor = style.topBarBackground.getColor();
            btnMini.ForeColor = style.topBarButtonMin.getColor();
            btnClose.BackColor = style.topBarBackground.getColor();
            btnClose.ForeColor = style.topBarButtonClose.getColor();
            btnMax.BackColor = style.topBarBackground.getColor();
            btnMax.ForeColor = style.topBarButtonMax.getColor();
        }

        public void updateText()
        {
            windowText.Text = this.ParentForm.Text;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if(this.ParentForm.WindowState==FormWindowState.Maximized)
                this.ParentForm.WindowState = FormWindowState.Normal;
            else
            this.ParentForm.WindowState = FormWindowState.Maximized;
        }
    }
}
