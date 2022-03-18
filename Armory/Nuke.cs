using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Armory
{
    internal class Nuke
    {
        public  void Bomb()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"..\..\Sound\easteregg.wav";
            player.PlaySync();

        }
        
    }
}
