using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Vapour
{
    public partial class IconExtractorForm : Form
    {
        public IconExtractorForm()
        {
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;
        }

        private void IconExtractor_Load(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                Close();
            }

            try
            {
                var icons = IconExtractor.ExtractIconsFromExe(openFileDialog1.FileName);
                var i = 0;
                listView1.BeginUpdate();
                foreach (var icon in icons)
                {
                    var item = new ListViewItem("Icon #" + i.ToString());
                    imageList1.Images.Add(icon);
                    item.ImageIndex = i;
                    item.Tag = icon;
                    listView1.Items.Add(item);
                    i++;
                }
                listView1.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to extract icons from executable: " + ex.Message, "Error extracting icons", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        //private static List<Icon> ExtractIconsFromExe(string file, bool large)
        //{
        //    var icons = new List<Icon>();
        //    uint readIconCount = 0;
        //    IntPtr[] hDummy = new IntPtr[1] { IntPtr.Zero };
        //    IntPtr[] hIconEx = new IntPtr[1] { IntPtr.Zero };

        //    try
        //    {
        //        if (large)
        //        {
        //            readIconCount = ExtractIconEx(file, 0, hIconEx, hDummy, 1);
        //        }
        //        else
        //        {
        //            readIconCount = ExtractIconEx(file, 0, hDummy, hIconEx, 1);
        //        }

        //        if (readIconCount > 0 && hIconEx[0] != IntPtr.Zero)
        //        {
        //            for (var i = 0; i < readIconCount; i++)
        //            {
        //                Icon icon = (Icon)Icon.FromHandle(hIconEx[0]).Clone();
        //                icons.Add(icon);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        /* EXTRACT ICON ERROR */

        //        // BUBBLE UP
        //        throw new ApplicationException("Could not extract icon", ex);
        //    }
        //    finally
        //    {
        //        // RELEASE RESOURCES
        //        foreach (IntPtr ptr in hIconEx)
        //        {
        //            if (ptr != IntPtr.Zero)
        //            {
        //                DestroyIcon(ptr);
        //            }
        //        }

        //        foreach (IntPtr ptr in hDummy)
        //        {
        //            if (ptr != IntPtr.Zero)
        //            {
        //                DestroyIcon(ptr);
        //            }
        //        }
        //    }
        //    return icons;
        //}

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                return;
            }

            Icon icon = (Icon)listView1.SelectedItems[0].Tag;

            label1.Text = "Size: " + icon.Size.Width.ToString() + "x" + icon.Size.Height.ToString();
            label2.Text = "Bit depth: " + icon.ToBitmap().PixelFormat.ToString();
            pictureBox1.Width = icon.Width + 2;
            pictureBox1.Height = icon.Height + 2;
            pictureBox1.Image = icon.ToBitmap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
            {
                return;
            }

            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            Icon icon = (Icon)listView1.SelectedItems[0].Tag;
            var file = File.Create(saveFileDialog1.FileName);
            //icon.Save(file);

            icon.ToBitmap().Save(file, System.Drawing.Imaging.ImageFormat.Png);
            file.Flush();
            file.Close();
        }
    }
}
