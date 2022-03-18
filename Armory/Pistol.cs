using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Armory
{
    class Pistol : Firearm
    {
        public Pistol()
        {
            this.Caliber = Caliber.Small;
            this.MaxMagSize = 15;
            this.Mag = 0;
        }

        public override void Fire()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\Pistol.wav";
            player.PlaySync();
            this.Mag--;
        }

        public override void Reload()
        {
            if (this.Mag!=this.MaxMagSize)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"..\..\Sound\Reload1.wav";
                player.Play();
                this.Mag = MaxMagSize;
            }
        }
    }
}
