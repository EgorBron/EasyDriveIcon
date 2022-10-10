using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace EsDriveIco {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            driveLetterComboBox.SelectedItem = "C";
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void pathToIcoButton_Click(object sender, EventArgs e) {
            var iconPath = new OpenFileDialog();
            iconPath.Filter = "Icon|*.ico";
            if (iconPath.ShowDialog() == DialogResult.OK) {
                pathToIcoTextbox.Text = iconPath.FileName;
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            try {
                if (!File.Exists(pathToIcoTextbox.Text)) throw new NotSupportedException();
            } catch (NotSupportedException) { MessageBox.Show("Provided path is invalid", "EsDriveIco - Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            string imgpath = pathToIcoTextbox.Text;
            File.WriteAllBytes(Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                Path.GetFileName(imgpath)
                ), File.ReadAllBytes(pathToIcoTextbox.Text));
            var driveicons = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons", true);
            var iconpathreg = driveicons.CreateSubKey(driveLetterComboBox.SelectedItem.ToString()+ "\\DefaultIcon");
            iconpathreg.SetValue("", "\""+imgpath+ "\"");
            MessageBox.Show("Done", "EsDriveIco");
        }

        private void resetButton_Click(object sender, EventArgs e) {
            var driveicons = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\DriveIcons", true);
            driveicons.DeleteSubKeyTree(driveLetterComboBox.SelectedItem.ToString());
            MessageBox.Show("Done", "EsDriveIco");
        }
    }
}
