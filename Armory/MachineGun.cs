using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Armory
{
    internal class MachineGun:Firearm,IFireMode
    {
        public MachineGun()
        {
            this.Caliber = Caliber.Medium;
            this.MaxMagSize = 30;
            this.Mag = 0;
        }
       public MachineGun(string name, double weight, string desc, string brand,Caliber cal) :base(name,weight,desc,brand,cal)
        {
            this.MaxMagSize = 30;
            this.Mag = 0;
            this.Caliber = cal;
        }

        public override void Fire()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\MachineGunFire.wav";
            player.PlaySync();
            this.Mag--;
        }

        public void FullAuto()
        {
            int i = 0;
            while (i <= 4)
            {
                Fire();
                i++;
            }
            this.Mag = 0;
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

        public void SemiAuto()
        {
            Fire();
            Fire();
            this.Mag -= 3;
        }
    }
}
