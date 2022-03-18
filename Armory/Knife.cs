using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Armory
{
    internal class Knife : Weapon, ICuttingThings
    {
        public int Durability { get; set; }
        public int MaxDurability { get; set; }

        public Knife()
        {
            this.Durability = 0;
            this.MaxDurability = 10;
        }

        public void Cut()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\StabKnife.wav";
            player.PlaySync();
            this.Durability--;
            
        }

        public void Sharpening()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\SharpenKnife.wav";
            player.PlaySync();
            this.Durability = MaxDurability;
        }
    }
}
