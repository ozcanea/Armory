using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Armory
{
    internal abstract class Weapon
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public string Brand { get; set; }
        public Weapon()
        {

        }
        public Weapon(string name, double weight, string desc, string brand)
        {
            this.Name = name;
            this.Weight = weight;
            this.Description = desc;
            this.Brand = brand;

        }

        public void Kill()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\Death.wav";
            player.PlaySync();
            MessageBox.Show("Target Terminated!", "Congrats Soldier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void Wounded()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\scream.wav";
            player.PlaySync();
            MessageBox.Show("Target Injured But Escaped!", "Damn Son", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
