using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vapour
{
    public partial class Form1 : Form
    {
        private GameRegistry gameRegistry;
        public Form1()
        {
            InitializeComponent();
            Font = SystemFonts.MessageBoxFont;

            gameRegistry = new GameRegistry();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Game game in gameRegistry.Games)
            {
                flowLayoutPanel1.Controls.Add(new GameControl(game));
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    //var ctrl = new GameControl();
            //    //ctrl.Parent = this;
            //    flowLayoutPanel1.Controls.Add(new GameControl("Game #" + i.ToString()));
            //}
        }

        private void iconExtractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new IconExtractorForm()).Show();
        }

        private void createGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new NewVapourGame()).Show();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            toolStripProgressBar1.Size = new Size(Width - 80, toolStripProgressBar1.Size.Height);
        }
    }
}
