using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWExtractToolkit
{
    public partial class helpForm : Form
    {
       

        //***********************************************************
        //This gives us the ability to resize the borderless from any borders instead of just the lower right corner
        protected override void WndProc(ref Message m)
        {
            const int wmNcHitTest = 0x84;
            const int htLeft = 10;
            const int htRight = 11;
            const int htTop = 12;
            const int htTopLeft = 13;
            const int htTopRight = 14;
            const int htBottom = 15;
            const int htBottomLeft = 16;
            const int htBottomRight = 17;

            if (m.Msg == wmNcHitTest)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point pt = PointToClient(new Point(x, y));
                Size clientSize = ClientSize;
                ///allow resize on the lower right corner
                if (pt.X >= clientSize.Width - 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomLeft : htBottomRight);
                    return;
                }
                ///allow resize on the lower left corner
                if (pt.X <= 16 && pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htBottomRight : htBottomLeft);
                    return;
                }
                ///allow resize on the upper right corner
                if (pt.X <= 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopRight : htTopLeft);
                    return;
                }
                ///allow resize on the upper left corner
                if (pt.X >= clientSize.Width - 16 && pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(IsMirrored ? htTopLeft : htTopRight);
                    return;
                }
                ///allow resize on the top border
                if (pt.Y <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htTop);
                    return;
                }
                ///allow resize on the bottom border
                if (pt.Y >= clientSize.Height - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htBottom);
                    return;
                }
                ///allow resize on the left border
                if (pt.X <= 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htLeft);
                    return;
                }
                ///allow resize on the right border
                if (pt.X >= clientSize.Width - 16 && clientSize.Height >= 16)
                {
                    m.Result = (IntPtr)(htRight);
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //***********************************************************






        SharedCode sc = new SharedCode();
        public helpForm()
        {
            InitializeComponent();
        }

        private void helpForm_Load(object sender, EventArgs e)
        {
            //Style form
            Theme theme = new Theme();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    sc.styleButtons(c);
                }

                if (c is Label)
                {
                    c.ForeColor = theme.getCurrentStyle().labelStatic.getColor();
                }

                if (c is TextBox)
                {
                    if (((TextBox)c).ReadOnly)
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
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yernemm.xyz/blog/owet-guide/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yernemm.xyz/contact");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://facepunch.com/showthread.php?t=1578997");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yernemm.xyz/projects/owet"); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/uqhkBt8");
        }
    }
}
