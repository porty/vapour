using System;
using System.Collections.Generic;
using System.Text;

namespace Vapour
{
    class GameRegistry
    {
        private List<Game> games;

        public GameRegistry()
        {
            this.games = new List<Game>();

            games.Add(new Game("StarCraft", @"C:\Program Files (x86)\StarCraft", "StarCraft.exe", ""));
            games.Add(new Game("Total Annihilation", @"D:\gog\ta\Total Annihilation", "TotalA.exe", ""));
            games.Add(new Game("CnC Generals", @"D:\games\generals", "generals.exe", "-quickstart"));
            games.Add(new Game("Crysis", @"D:\games\Crysis", @"Bin64\Crysis64.exe", ""));
        }

        public ICollection<Game> Games
        {
            get { return games; }
        }
    }
}
