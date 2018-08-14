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
    public partial class themeSample : Form
    {
        Style pS;
        SharedCode sc = new SharedCode();
        public themeSample(Style previewStyle)
        {
            InitializeComponent();
            pS = previewStyle;
        }

        private void themeSample_Load(object sender, EventArgs e)
        {
            this.Text = pS.name;
            topBarMaxim1.updateText();

            //Style Form Theme
            
            
            foreach (Control c in this.Controls)
            {
                styleControl(c);
            }



            void styleControl(Control c)
            {
                if (c is Button)
                {
                    
                    Button b = c as Button;
                    b.FlatStyle = FlatStyle.Flat;
                    b.BackColor = pS.buttonBackground.getColor();
                    b.ForeColor = pS.buttonText.getColor();
                    b.FlatAppearance.BorderColor = pS.buttonBorder.getColor();
                    b.FlatAppearance.BorderSize = 1;
                }

                if (c is Label)
                {
                    c.ForeColor = pS.labelStatic.getColor();
                }

                if (c is TextBox)
                {
                    if (((TextBox)c).ReadOnly)
                    {
                        c.BackColor = pS.textBoxReadOnlyBackground.getColor();
                        c.ForeColor = pS.textBoxReadOnlyText.getColor();
                    }
                    else
                    {
                        c.BackColor = pS.textBoxInputBackground.getColor();
                        c.ForeColor = pS.textBoxInputText.getColor();
                    }
                }

                if (c is ComboBox)
                {
                    c.BackColor = pS.textBoxInputBackground.getColor();
                    c.ForeColor = pS.textBoxInputText.getColor();
                }
            }
            this.BackColor = pS.background.getColor();
            unsavedWarning.ForeColor = pS.textWarning.getColor();
            label2.ForeColor = pS.labelDynamic.getColor();
            textBoxUnsaved.ForeColor = pS.settingsTextUnsaved.getColor();

            //

            topBarMaxim1.setTheme(pS);
        }
    }
}
