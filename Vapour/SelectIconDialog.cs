using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vapour
{
    public partial class SelectIconDialog : Form
    {
        private List<Icon> icons;

        public SelectIconDialog(List<Icon> icons)
        {
            this.icons = icons;
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
        }

        public SelectIconDialog(string filename)
        {
            this.icons = IconExtractor.ExtractIconsFromExe(filename);
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public Icon LargeIcon
        {
            get;
            set;
        }

        public Icon SmallIcon
        {
            get;
            set;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = BothIconsSelected();

            if (bigListView.SelectedItems.Count != 1)
            {
                return;
            }

            LargeIcon = (Icon)bigListView.SelectedItems[0].Tag;
        }

        private bool BothIconsSelected()
        {
            return bigListView.SelectedItems.Count == 1 && smallListView.SelectedItems.Count == 1;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = BothIconsSelected();

            if (smallListView.SelectedItems.Count != 1)
            {
                return;
            }

            SmallIcon = (Icon)smallListView.SelectedItems[0].Tag;
        }

        private void SelectIconDialog_Load(object sender, EventArgs e)
        {
            bigListView.BeginUpdate();
            smallListView.BeginUpdate();

            foreach (var icon in icons)
            {
                var item = new ListViewItem();
                item.Tag = icon;
                if (icon.Width == 32)
                {
                    bigImageList.Images.Add(icon);
                    var index = bigImageList.Images.Count - 1;
                    item.ImageIndex = index;
                    bigListView.Items.Add(item);
                }
                else if (icon.Width == 16)
                {
                    smallImageList.Images.Add(icon);
                    var index = smallImageList.Images.Count - 1;
                    item.ImageIndex = index;
                    smallListView.Items.Add(item);
                }
            }

            bigListView.EndUpdate();
            smallListView.EndUpdate();
        }
    }
}
