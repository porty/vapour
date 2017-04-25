namespace Vapour
{
    partial class GameControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameControl));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miPlayGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miDesktopShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.miMoveInstallDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.miExplore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.miUninstall = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "StarCraft";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPlayGame,
            this.toolStripSeparator1,
            this.miDesktopShortcut,
            this.miMoveInstallDirectory,
            this.miExplore,
            this.toolStripSeparator2,
            this.miUninstall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 126);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // miPlayGame
            // 
            this.miPlayGame.Name = "miPlayGame";
            this.miPlayGame.Size = new System.Drawing.Size(199, 22);
            this.miPlayGame.Text = "Play Game";
            this.miPlayGame.Click += new System.EventHandler(this.miPlayGame_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // miDesktopShortcut
            // 
            this.miDesktopShortcut.Name = "miDesktopShortcut";
            this.miDesktopShortcut.Size = new System.Drawing.Size(199, 22);
            this.miDesktopShortcut.Text = "Create desktop shortcut";
            // 
            // miMoveInstallDirectory
            // 
            this.miMoveInstallDirectory.Name = "miMoveInstallDirectory";
            this.miMoveInstallDirectory.Size = new System.Drawing.Size(199, 22);
            this.miMoveInstallDirectory.Text = "Move installation directory...";
            // 
            // miExplore
            // 
            this.miExplore.Name = "miExplore";
            this.miExplore.Size = new System.Drawing.Size(199, 22);
            this.miExplore.Text = "Explore installation directory";
            this.miExplore.Click += new System.EventHandler(this.miExplore_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // miUninstall
            // 
            this.miUninstall.Name = "miUninstall";
            this.miUninstall.Size = new System.Drawing.Size(199, 22);
            this.miUninstall.Text = "Uninstall...";
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(576, 18);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miPlayGame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miDesktopShortcut;
        private System.Windows.Forms.ToolStripMenuItem miUninstall;
        private System.Windows.Forms.ToolStripMenuItem miMoveInstallDirectory;
        private System.Windows.Forms.ToolStripMenuItem miExplore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
