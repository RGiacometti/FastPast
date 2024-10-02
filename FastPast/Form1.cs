namespace FastPast
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            HotKeyManager.RegisterHotKey(Keys.V, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
        }

        void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}