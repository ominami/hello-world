using System;
using Microsoft.Win32;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        private RegistryKey registryKey;

        public Form1()
        {
            InitializeComponent();
            registryKey = Registry.CurrentUser.OpenSubKey("USER_APP_DATA", true);
            if (registryKey == null)
            {
                registryKey = Registry.CurrentUser.CreateSubKey("USER_APP_DATA", true);
            }
        }

        private Color GetColor(string clr)
        {
            switch (clr)
            {
                case "Red":
                    return Color.Red;
                case "Blue":
                    return Color.Blue;
                case "Green":
                    return Color.Green;
                case "Yellow":
                    return Color.Yellow;
                case "Orange":
                    return Color.Orange;
                case "Lime":
                    return Color.Lime;
                default:
                    return DefaultDataOfWindow.DEFAULT_COLOR;
            }
        }

        private void WindowSize_Click(object sender, EventArgs e)
        {
            string height = WindowHeight.Text;
            string width = WindowWidth.Text;
            int numericValue;
            bool isNumberHeight = int.TryParse(WindowHeight.Text, out numericValue);
            bool isNumberWidth = int.TryParse(WindowWidth.Text, out numericValue);
            if (isNumberHeight && isNumberWidth)
            {
                this.Height = Convert.ToInt32(height); 
                this.Width = Convert.ToInt32(width);
            }
            else MessageBox.Show("This is not a number.", "Error");
        }

        private void WindowColor_Click(object sender, EventArgs e)
        {
            if (ColorList.SelectedItems.Count != 0)
            {
                BackColor = GetColor(ColorList.SelectedItem.ToString());
            }
            else MessageBox.Show("No color was chosen.", "Error");
        }

        private void UploadSettings_Click(object sender, EventArgs e)
        {
            foreach (var i in registryKey.GetValueNames())
            {
                DownloadFromRegistery(i);
            }
        }

        private void DownloadFromRegistery(string registery)
        {
            switch (registery)
            {
                case "back_color":
                    this.BackColor = GetColor(registryKey.GetValue("back_color").ToString());
                    break;
                case "height_text":
                    WindowHeight.Text = registryKey.GetValue("height_text").ToString();
                    this.Height = Convert.ToInt32(WindowHeight.Text);
                    break;
                case "width_text":
                    WindowWidth.Text = registryKey.GetValue("width_text").ToString();
                    this.Width = Convert.ToInt32(WindowWidth.Text);
                    break;
            }
        }

        private void ResetSettings_Click(object sender, EventArgs e)
        {
            this.BackColor = DefaultDataOfWindow.DEFAULT_COLOR;
            this.Width = DefaultDataOfWindow.DEFAULT_WIDTH;
            this.Height = DefaultDataOfWindow.DEFAULT_HEIGT;

            if (registryKey.GetValue("back_color") != null)
            {
                registryKey.DeleteValue("back_color");
            }

            if (registryKey.GetValue("height_text") != null)
            {
                WindowHeight.Text = "414";
                registryKey.DeleteValue("height_text");
            }
            if (registryKey.GetValue("width_text") != null)
            {
                WindowWidth.Text = "560";
                registryKey.DeleteValue("width_text");
            }
        }

        public static class DefaultDataOfWindow
        {
            public static Color DEFAULT_COLOR = Color.White;
            public static int DEFAULT_WIDTH = 560;
            public static int DEFAULT_HEIGT = 414;
            public static int DEFAULT_SIZE = 0;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            if (ColorList.SelectedItems.Count != 0)
            {
                registryKey.SetValue("back_color", ColorList.SelectedItem.ToString());
            }
            else MessageBox.Show("No color was chosen.", "Error");
            int numericValue;
            bool isNumberHeight = int.TryParse(WindowHeight.Text, out numericValue);
            bool isNumberWidth = int.TryParse(WindowWidth.Text, out numericValue);
            if (isNumberHeight && isNumberWidth)
            {
                registryKey.SetValue("height_text", WindowHeight.Text);
                registryKey.SetValue("width_text", WindowWidth.Text);
            }
            else MessageBox.Show("This is not a number.", "Error");
        }

    }
}