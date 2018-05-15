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
    public partial class ExtractWizard : Form
    {
        public ExtractWizard()
        {
            InitializeComponent();
        }

        int depth = 0;

        private void ExtractWizard_Load(object sender, EventArgs e)
        {
           setPage("What do you want to do?", new string[] { "Extract", "List"} ,0);
        }
        
        Button makeButton(string text, string id)
        {
            Button b = new Button();
            b.FlatStyle = FlatStyle.Flat;
            b.BackColor = Color.OrangeRed;
            b.ForeColor = Color.Aqua;
            b.FlatAppearance.BorderColor = Color.Orange;
            b.FlatAppearance.BorderSize = 1;
            b.Text = text;
            b.Tag = id;
            b.Width = (int)(0.23 * mainFlowPanel.Width);
            b.Height = 40;
            b.Click += mainBtnClick;
            return b;

        }

        void addBtn(Button btn)
        {
            mainFlowPanel.Controls.Add(btn);
        }

        void addNewBtn(string text, string id)
        {
            addBtn(makeButton(text, id));
        }

        void setQ(string que)
        {
            mainBox.Text = que;
        }

        void addToHistory(string entry)
        {
            mainListBox.Items.Add(entry);
        }

        void setPage(string question, string[] buttons, int id)
        {
            reset();
            setQ(question);
            for (int i = 0; i < buttons.Length; i++)
                addNewBtn(buttons[i], i.ToString());
            depth = id;
        }
        
        void reset()
        {
            mainBox.Text = "";
            // mainListBox.Items.Clear();

             mainFlowPanel.Controls.Clear();
            
        }

        void mainBtnClick(Object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var id = btn.Tag;
            addToHistory(btn.Text);
            switch (depth)
            {
                case 0:
                    //First stage
                    switch (id)
                    {
                        case "0":
                            //Extract btn                          
                            setPage("What do you want to extract?", new string[] { "General Unlocks", "Hero Items and Unlocks", "Lootboxes", "Hero Sounds and Voice", "Map", "All Ability Icons", "NPC"}, 1);
                            break;
                        case "1":
                            //List
                            setPage("What do you want to list?", new string[] { "General Unlocks", "Hero Unlocks", "Lootboxes", "Heroes", "Maps", "Highlights", "First set of Subtitles", "Second set of Subtitles", "Chat Replacements", "Encryption Keys", "Strings", "Achievements" }, 2);
                            break;
                    }

                    break;

            }

        }
    }
}
