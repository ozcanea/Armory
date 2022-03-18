using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Armory
{
    internal class Mortar:Firearm
    {
        public override void Fire()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\Mortar.wav";
            player.PlaySync();
            this.Mag--;
        }
        public override void Reload()
        {
            if (this.Mag != this.MaxMagSize)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"..\..\Sound\MachineGunReload.wav";
                player.PlaySync();
                this.Mag = MaxMagSize;
            }
        }
       public  Mortar()
        {
            this.Mag = 0;
            this.MaxMagSize = 1;
        }
    }
}
