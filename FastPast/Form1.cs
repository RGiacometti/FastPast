
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Input;

namespace FastPast
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            HotKeyManager.RegisterHotKey(Keys.V, KeyModifiers.Control | KeyModifiers.Shift | KeyModifiers.NoRepeat);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }

        void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {

            // wait 3 seconds
            System.Threading.Thread.Sleep(1000);
            
            string text = convertCheckBox.Checked ? ConvertFRtoUS(textPast.Text) : textPast.Text;

            SendKeys.Send(text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private string ConvertFRtoUS(string text)
        {
            // Dictionary to convert French characters to US characters
            Dictionary<int, int> frToUs = new Dictionary<int, int> {
                 { 97  , 113  }, // Asc("a")  , Asc("q")
                 { 122 , 119  }, // Asc("z")  , Asc("w") 
                 { 113 , 97   }, // Asc("q")  , Asc("a")
                 { 119 , 122  }, // Asc("w")  , Asc("z") 
                 { 65  , 81   }, // Asc("A")  , Asc("Q")
                 { 90  , 87   }, // Asc("Z")  , Asc("W")
                 { 81  , 65   }, // Asc("Q")  , Asc("A")
                 { 87  , 90   }, // Asc("W")  , Asc("Z")
                 { 38  , 49   }, // Asc("&")  , Asc("1")
                 { 233 , 50   }, // Asc("é")  , Asc("2")
                 { 34  , 51   }, // Asc("""") , Asc("3")
                 { 39  , 52   }, // Asc("'")  , Asc("4")
                 { 40  , 53   }, // Asc("(")  , Asc("5")
                 { 45  , 54   }, // Asc("-")  , Asc("6")
                 { 232 , 55   }, // Asc("è")  , Asc("7")
                 { 95  , 56   }, // Asc("_")  , Asc("8")
                 { 231 , 57   }, // Asc("ç")  , Asc("9")
                 { 224 , 48   }, // Asc("à")  , Asc("0")
                 { 41  , 45   }, // Asc(")")  , Asc("-")
                 { 94  , 91   }, // Asc("^")  , Asc("[")
                 { 36  , 93   }, // Asc("$")  , Asc("]")
                 { 77  , 58   }, // Asc("M")  , Asc(",")
                 { 249 , 39   }, // Asc("ù")  , Asc("'")
                 { 44  , 109  }, // Asc("{")  , Asc("m") 
                 { 63  , 77   }, // Asc("?")  , Asc("M")
                 { 59  , 44   }, // Asc(";")  , Asc(",")
                 { 58  , 46   }, // Asc(",")  , Asc(".")
                 { 33  , 47   }, // Asc("!")  , Asc("/")
                 { 167 , 63   }, // Asc("§")  , Asc("?")
                 { 49  , 33   }, // Asc("1")  , Asc("!")
                 { 50  , 64   }, // Asc("2")  , Asc("@")
                 { 51  , 35   }, // Asc("3")  , Asc("#")
                 { 52  , 36   }, // Asc("4")  , Asc("$")
                 { 53  , 37   }, // Asc("5")  , Asc("%")
                 { 54  , 94   }, // Asc("6")  , Asc("^")
                 { 55  , 38   }, // Asc("7")  , Asc("&")
                 { 56  , 42   }, // Asc("8")  , Asc("*")
                 { 57  , 40   }, // Asc("9")  , Asc("(")
                 { 48  , 41   }, // Asc("0")  , Asc(")")
            };

            string result = string.Empty;

            // Convert each character if it is in the dictionary
            foreach (char c in text)
            {
                int ascii = (int)c;
                result += frToUs.ContainsKey(ascii) ? (char)frToUs[ascii] : c;
            }

            return result;
        }

    }
}