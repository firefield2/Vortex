using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex
{
    public partial class Form3 : Form
    {
        //TODO Powiadomienie o niezpisanych danych przy zamknięciu
        public Form3()
        {
            InitializeComponent();
        }

        private void CanSaveData_CheckedChanged(object sender, EventArgs e)
        {
                directoryTextBox.Visible = canSaveData.Checked;
                chooseSaveDirectory.Visible = canSaveData.Checked;
        }

        private void ChooseSaveDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directoryTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void DirectoryTextBox_TextChanged(object sender, EventArgs e)
        {
            directoryTip.SetToolTip(sender as TextBox, (sender as TextBox).Text);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string errorMessage = String.Empty;
            if(!String.IsNullOrEmpty(serverAdressTextBox.Text))
            {
                Settings.UrlAdress = serverAdressTextBox.Text;
            }
            else
            {
                errorMessage += "Nie podano adresu serwera!\r\n";
            }

            if (canSaveData.Checked)
            {
                if (Directory.Exists(directoryTextBox.Text))
                {
                    Settings.Path = directoryTextBox.Text;
                    Settings.ChartAllow = true;
                }
                else
                {
                    errorMessage += "Zła ścieżka zapisu!\r\n";
                }
            }
            else
            {
                Settings.ChartAllow = false;
            }
            if (!String.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            canSaveData.Checked = Settings.ChartAllow;
            directoryTextBox.Text = Settings.Path;
            serverAdressTextBox.Text = Settings.UrlAdress;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            AcceptButton_Click(sender, e);
            this.Close();
        }
    }
}
