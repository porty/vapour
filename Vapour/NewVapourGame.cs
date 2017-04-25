using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vapour
{
    public partial class NewVapourGame : Form
    {
        public NewVapourGame()
        {
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            tbxDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
            openFileDialog1.InitialDirectory = tbxDirectory.Text;
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            tbxExecutable.Text = openFileDialog1.FileName;

            selectIconsFromExecutable(openFileDialog1.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectIconsFromExecutable(tbxExecutable.Text);
        }

        private void selectIconsFromExecutable(string executable)
        {
            if (!System.IO.File.Exists(executable))
            {
                MessageBox.Show("File doesn't exist", "Can't extract icons", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dialog = new SelectIconDialog(executable);
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            pbxLargeIcon.Image = dialog.LargeIcon.ToBitmap();
            pbxSmallIcon.Image = dialog.SmallIcon.ToBitmap();
        }
    }
}
