using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Vapour
{
    class IconExtractor
    {
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        static extern uint ExtractIconEx(string szFileName, int nIconIndex, IntPtr[] phiconLarge, IntPtr[] phiconSmall, uint nIcons);
        [DllImport("shell32.dll", CharSet = CharSet.Auto, EntryPoint = "ExtractIconEx")]
        static extern uint ExtractIconEx2(string szFileName, int nIconIndex, IntPtr phiconLarge, IntPtr phiconSmall, uint nIcons);
        [DllImport("user32.dll", EntryPoint = "DestroyIcon", SetLastError = true)]
        private static extern int DestroyIcon(IntPtr hIcon);

        public static List<Icon> ExtractIconsFromExe(string file)
        {
            var icons = new List<Icon>();
            var count = ExtractIconEx2(file, -1, IntPtr.Zero, IntPtr.Zero, 0);
            for (uint i = 0; i < count; i++)
            {
                var large = new IntPtr[1] { IntPtr.Zero };
                var small = new IntPtr[1] { IntPtr.Zero };
                ExtractIconEx(file, (int)i, large, small, 1);
                if (large[0] != IntPtr.Zero)
                {
                    icons.Add((Icon)Icon.FromHandle(large[0]).Clone());
                    DestroyIcon(large[0]);
                }
                if (small[0] != IntPtr.Zero)
                {
                    icons.Add((Icon)Icon.FromHandle(small[0]).Clone());
                    DestroyIcon(small[0]);
                }
            }
            return icons;
        }
    }
}
