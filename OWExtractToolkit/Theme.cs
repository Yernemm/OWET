using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Windows.Forms;

namespace OWExtractToolkit
{
    
    public class themeColour
    {


        //0 to 255
        private int r;
        private int g;
        private int b;

        public Color getColor()
        {
            Color c = new Color();
            c = Color.FromArgb(255, r, g, b);
            return c;
        }

        public int getR()
        {
            return r;
        }

        public int getG()
        {
            return g;
        }

        public int getB()
        {
            return b;
        }

        public string getHex()
        {
            return "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
        }

        public bool setHex(string hex)
        {
            if (hex.Length == 7)
            {
                return setRGB(Convert.ToInt32(hex.Substring(1, 2), 16), Convert.ToInt32(hex.Substring(3, 2), 16), Convert.ToInt32(hex.Substring(5, 2), 16));
            }
            // else if (hex.Length == 4)
            // {
            //     return setRGB(Convert.ToInt32(hex.Substring(1, 1), 16) * 16, Convert.ToInt32(hex.Substring(2, 1), 16) * 16, Convert.ToInt32(hex.Substring(3, 1), 16) * 16);
            // }
            else
                return false;
        }

        public bool setRGB(int r, int g, int b)
        {
            return (setR(r) && setG(g) && setB(b));
        }

        public bool setR(int a)
        {
            return setCol(a, 0);
        }

        public bool setG(int a)
        {
            return setCol(a, 1);
        }

        public bool setB(int a)
        {
            return setCol(a, 2);
        }


        private bool setCol(int a, int index)
        {
            if (a >= 0 && a <= 255)
            {
                switch (index)
                {
                    case 0:
                        r = a;
                        break;

                    case 1:
                        g = a;
                        break;

                    case 2:
                        b = a;
                        break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public themeColour() { }
    }

    public class Style
    {
        public string name;
        //Normal buttons
        public themeColour buttonBackground = new themeColour();
        public themeColour buttonBorder = new themeColour();
        public themeColour buttonText = new themeColour();
        //Textboxes
        public themeColour textBoxInputText = new themeColour();
        public themeColour textBoxInputBackground = new themeColour();     
        public themeColour textBoxReadOnlyText = new themeColour();
        public themeColour textBoxReadOnlyBackground = new themeColour();
        //Labels
        public themeColour labelStatic = new themeColour();
        public themeColour labelDynamic = new themeColour();
        //Top bar
        public themeColour topBarBackground = new themeColour();
        public themeColour topBarText = new themeColour();
        public themeColour topBarButtonMin = new themeColour();
        public themeColour topBarButtonMax = new themeColour();
        public themeColour topBarButtonClose = new themeColour();
        //Other
        public themeColour background = new themeColour();
        public themeColour settingsTextUnsaved = new themeColour();
        public themeColour textWarning = new themeColour();
        

        public Style()
        {

        }
    }

    public class Theme
    {
        SharedCode sc = new SharedCode();
        public void init()
        {
            
            


        }



        public Style getCurrentStyle()
        {
            //return StyleOWET();
            //return fileToStyle(@"C:\Users\Bakk\AppData\Roaming\Yernemm\OWExtractToolkit\Themes\sample.owett");
            string setTheme;
            if (File.Exists(sc.themesSetting))
                setTheme = File.ReadAllText(sc.themesSetting);
            else
                setTheme = "[default]";
            if (setTheme == sc.themesDefault)
                return StyleOWET();
            else
            {
                if (File.Exists(sc.themesPath + @"\" + setTheme + ".owett"))
                {
                    return fileToStyle(sc.themesPath + @"\" + setTheme + ".owett");
                }
                else
                {
                    //MessageBox.Show("ERROR: Theme not found. Setting default theme. Please change to an existsing theme in the settings.");
                    return StyleOWET();
                }
            }
        }

        public Style fileToStyle(string path)
        {
            return stringToStyle(System.IO.File.ReadAllText(path));
        }

        Style stringToStyle(string fileText)
        {
            Style customStyle = new Style();

            string[] lines = fileText.Split(
            new[] { Environment.NewLine },
            StringSplitOptions.None
            );

            foreach(string line in lines)
            {
                if (line.ToCharArray()[0] != '#' && line.Length > 3)
                {
                    string[] parts = line.Split(':');

                    if (parts[0] == "name")
                    {
                        customStyle.name = parts[1];
                    }
                    else
                    {
                        themeColour customColour = new themeColour();
                        customColour.setHex(parts[1]);
                       

                        typeof(Style).GetField(parts[0]).SetValue(customStyle, customColour);
                        
                    }
                }
            }

            return customStyle;


        }

        public Style StyleOWET()
        {
            Style owetStyle = new Style();

            owetStyle.name = "Original OWET Theme";

            owetStyle.buttonBackground.setRGB(255, 69, 0);
            owetStyle.buttonBorder.setRGB(255, 165, 0);
            owetStyle.buttonText.setRGB(0, 255, 255);

            owetStyle.textBoxInputText.setRGB(127, 255, 212);
            owetStyle.textBoxInputBackground.setRGB(8, 25, 40);
            owetStyle.textBoxReadOnlyText.setRGB(255, 128, 0);
            owetStyle.textBoxReadOnlyBackground.setRGB(8, 25, 40);

            owetStyle.labelStatic.setRGB(255, 128, 0);
            owetStyle.labelDynamic.setRGB(0, 255, 255);

            owetStyle.topBarBackground.setRGB(33, 55, 89);
            owetStyle.topBarButtonClose.setRGB(255, 128, 0);
            owetStyle.topBarButtonMax.setRGB(255, 128, 0);
            owetStyle.topBarButtonMin.setRGB(255, 128, 0);
            owetStyle.topBarText.setRGB(255, 128, 0);

            owetStyle.background.setRGB(8, 25, 40);
            owetStyle.settingsTextUnsaved.setRGB(255, 69, 0);
            owetStyle.textWarning.setRGB(255, 69, 0);

            return owetStyle;
        }

        public string coreThemeText(string name)
        {
            switch (name)
            {
                case "light":
                    return @"#Custom OWET Theme.
name:Light Theme
#Normal buttons
buttonBackground:#cecece
buttonBorder:#4fbeff
buttonText:#282828
#Textboxes
textBoxInputText:#282828
textBoxInputBackground:#d3d3d3
textBoxReadOnlyText:#efefef
textBoxReadOnlyBackground:#4f4f4f
#Labels
labelStatic:#282828
labelDynamic:#2093a3
#Top bar
topBarBackground:#2a4282
topBarText:#efefef
topBarButtonMin:#ddb62b
topBarButtonMax:#2cc6dd
topBarButtonClose:#ff4747
#Other
background:#eaeced
settingsTextUnsaved:#a02121
textWarning:#d62f2f";
                case "sample":
                    return @"#Custom OWET Theme.
################################################################################
#Use the # sign at the start to leave comments.
#If you miss out a property then it will turn out black or cause problems, so change everything.
#If you add an invalid property, it may cause the program to crash.
#Properties are of a format 'Property: Value' with no spaces in between the two.
#All colours are 3-byte hex values with 1 byte per colour, starting with the # sign.
#This theme is just for testing. It is not intended for normal use.
################################################################################
name:Sample OWET Testing Theme
#Normal buttons
buttonBackground:#aabbcc
buttonBorder:#ccbbaa
buttonText:#000000
#Textboxes
textBoxInputText:#ffffff
textBoxInputBackground:#000000
textBoxReadOnlyText:#aaaaaa
textBoxReadOnlyBackground:#333333
#Labels
labelStatic:#ff0000
labelDynamic:#00ff00
#Top bar
topBarBackground:#333333
topBarText:#ffffff
topBarButtonMin:#0000ff
topBarButtonMax:#00ff00
topBarButtonClose:#ff0000
#Other
background:#555555
settingsTextUnsaved:#ff5555
textWarning:#aa0000";
                case "lightGrey":
                    return @"#Custom OWET Theme.
name:Light Grey Theme
# Normal buttons
buttonBackground:#cecece
buttonBorder:#6b6b6b
buttonText:#282828
#Textboxes
textBoxInputText:#282828
textBoxInputBackground:#d3d3d3
textBoxReadOnlyText:#efefef
textBoxReadOnlyBackground:#4f4f4f
#Labels
labelStatic:#282828
labelDynamic:#5b5b5b
#Top bar
topBarBackground:#6d6d6d
topBarText:#efefef
topBarButtonMin:#efefef
topBarButtonMax:#efefef
topBarButtonClose:#efefef
#Other
background:#f9f9f9
settingsTextUnsaved:#7c4242
textWarning:#844040";
                case "dark":
                    return @"#Custom OWET Theme.
name:Dark Theme
#Normal buttons
buttonBackground:#414b5b
buttonBorder:#4b78bc
buttonText:#e3e5e8
#Textboxes
textBoxInputText:#c9defc
textBoxInputBackground:#303030
textBoxReadOnlyText:#ededed
textBoxReadOnlyBackground:#4b4d51
#Labels
labelStatic:#b9d5ea
labelDynamic:#85b1fc
#Top bar
topBarBackground:#1c1c1c
topBarText:#bfbfbf
topBarButtonMin:#4ea5d8
topBarButtonMax:#4ea5d8
topBarButtonClose:#d84e4e
#Other
background:#353638
settingsTextUnsaved:#ff4b14
textWarning:#ff240c";
                default:
                    return "ERROR";
                    
            }
        }

    }

}
