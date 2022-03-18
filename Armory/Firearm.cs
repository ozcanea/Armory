using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armory
{
    public enum Caliber {Small,Medium,High}
    internal abstract class Firearm : Weapon
    {
        public short Mag { get; set; }
        public short MaxMagSize { get; set; }
        public Caliber Caliber { get; set; }

        abstract public void Fire();
        abstract public void Reload();
        public Firearm()
        {

        }
        public Firearm(string name, double weight, string desc, string brand,Caliber cal):base(name, weight, desc, brand)
        {
            this.Caliber = cal;
        }

    }
}
