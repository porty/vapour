using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;

namespace Vapour
{
    public class Game
    {
        public Game(string name, string directory, string executable, string args)
        {
            Name = name;
            Icon = Resources.starcraft_16.ToBitmap();
            Directory = directory;
            Executable = executable;
            Args = args;
        }

        public string Name
        {
            get;
        }

        public Image Icon
        {
            get;
        }

        public string Directory
        {
            get;
        }

        public string Executable
        {
            get;
        }

        public string Args
        {
            get;
        }

        public void Run()
        {
            Process.Start(Path.Combine(Directory, Executable));
        }

        public void Explore()
        {
            Process.Start(Directory);
        }
    }
}
