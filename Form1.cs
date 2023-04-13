using Microsoft.Win32;

namespace ColorSelectionChanger
{
    public partial class Main : Form
    {
        public RegistryKey ColorsRegisryDirectory = Registry.CurrentUser.OpenSubKey("Control Panel\\Colors",true)!;
        Color ColorFromPicker;
        string ColorString;
        string CurrentColorString;
        private Color convertToARGB(string colorString)
        {
            string[] colors = colorString.Split(' ');
            Color color = Color.FromArgb(
            Int32.Parse(colors[0]),
            Int32.Parse(colors[1]),
            Int32.Parse(colors[2]));

            return color;
        }

        public Main()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentColorString = (string)(ColorsRegisryDirectory.GetValue("HotTrackingColor"))!;
            CurrentColorTextBox.Text = CurrentColorString;
            CurrentColor.BackColor = convertToARGB((string)(ColorsRegisryDirectory.GetValue("HotTrackingColor"))!);
        }

        public void Form1_Close()
        {
            ColorsRegisryDirectory.Close();

        }


        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            if (ColorPicker.ShowDialog() == DialogResult.OK)
            {
                ColorFromPicker = ColorPicker.Color;
                ColorString = String.Format("{0} {1} {2}", ColorFromPicker.R, ColorFromPicker.G, ColorFromPicker.B);
            }

            ColorsRegisryDirectory.SetValue("Hilight", ColorString!);
            ColorsRegisryDirectory.SetValue("HotTrackingColor", ColorString!);

            CurrentColorString = (string)(ColorsRegisryDirectory.GetValue("HotTrackingColor"))!;
            CurrentColorTextBox.Text = CurrentColorString;
            CurrentColor.BackColor = convertToARGB((string)(ColorsRegisryDirectory.GetValue("HotTrackingColor"))!);

            MessageBox.Show("Color changed succesfully. Please reboot your PC to apply this color settings");
        }

        private void RestoreDefaultSettings_Click(object sender, EventArgs e)
        {
            CurrentColorTextBox.Text = "0 102 204";
            ColorsRegisryDirectory.SetValue("Hilight", "0 120 215");
            ColorsRegisryDirectory.SetValue("HotTrackingColor", "0 102 204");
            CurrentColorString = (string)(ColorsRegisryDirectory.GetValue("HotTrackingColor"))!;
            CurrentColor.BackColor = convertToARGB((string)(ColorsRegisryDirectory.GetValue("HotTrackingColor"))!);
            MessageBox.Show("Default color restored succesfully. Please reboot your PC to apply this color settings");
        }
    }
}