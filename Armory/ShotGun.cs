using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Armory
{
    internal class ShotGun : Firearm
    {
        public ShotGun()
        {
            this.Mag = 0;
            this.MaxMagSize = 2;
        }
       public ShotGun(string name, double weight, string desc, string brand, Caliber cal) :base(name, weight, desc, brand,cal)
        {
            this.Mag = 0;
            this.MaxMagSize = 2;
            this.Caliber = cal;
        }
        public override void Fire()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\Pumpgun.wav";
            player.PlaySync();
            this.Mag--;
        }

        public override void Reload()
        {
            if (this.Mag != this.MaxMagSize)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"..\..\Sound\PumpGunReload.wav";
                player.PlaySync();
                this.Mag++;
            }
        }

    }
}
