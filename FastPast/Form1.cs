
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
            SendKeys.Send(textPast.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}