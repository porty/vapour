using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Vapour
{
    public partial class GameControl : UserControl
    {
        private Game game;
        //public GameControl(string title)
        //{
        //    InitializeComponent();
        //    label1.Text = title;

        //    this.MouseEnter += HighlightRow;
        //    this.MouseLeave += UnhighlightRow;
        //    label1.MouseEnter += HighlightRow;
        //    label1.MouseLeave += UnhighlightRow;
        //    pictureBox1.MouseEnter += HighlightRow;
        //    pictureBox1.MouseLeave += UnhighlightRow;
        //}

        public GameControl(Game game)
        {
            this.game = game;
            InitializeComponent();
            label1.Text = game.Name;

            this.MouseEnter += HighlightRow;
            this.MouseLeave += UnhighlightRow;
            this.MouseDoubleClick += OnDoubleClick;
            label1.MouseEnter += HighlightRow;
            label1.MouseLeave += UnhighlightRow;
            label1.MouseDoubleClick += OnDoubleClick;
            pictureBox1.MouseEnter += HighlightRow;
            pictureBox1.MouseLeave += UnhighlightRow;
            pictureBox1.MouseDoubleClick += OnDoubleClick;
        }

        private void HighlightRow(object sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonHighlight;
        }

        private void UnhighlightRow(object sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void miPlayGame_Click(object sender, EventArgs e)
        {
            game.Run();
        }

        private void miExplore_Click(object sender, EventArgs e)
        {
            game.Explore();
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            game.Run();
        }
    }
}
