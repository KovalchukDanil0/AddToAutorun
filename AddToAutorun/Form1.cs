using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace AddToAutorun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileDialogATRButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.FileName = "Note*";
                openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK/* && */)
                {
                    toRunTextBox.Text = openFileDialog.FileName;
                }
            }
        }

        private void toRunTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddToAutorun_Key(true);
        }

        private void addKeyButton_Click(object sender, EventArgs e)
        {
            AddToAutorun_Key(true);
        }

        private void deleteKeyButton_Click(object sender, EventArgs e)
        {
            AddToAutorun_Key(false);
        }

        private void AddToAutorun_Key(bool b)
        {
            if (!string.IsNullOrWhiteSpace(toRunTextBox.Text) && File.Exists(toRunTextBox.Text))
            {
                SetAutorunValue(toRunTextBox.Text, b);
            }
        }

        private bool SetAutorunValue(string path, bool autorun)
        {
            RegistryKey reg;
            reg = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                if (autorun)
                    reg.SetValue(new DirectoryInfo(path).Name, path);
                else
                    reg.DeleteValue(new DirectoryInfo(path).Name);

                reg.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
