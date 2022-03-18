using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Firearm> firearms = new List<Firearm>();
        Knife knife = new Knife();
        MachineGun machineGun = new MachineGun();
        Pistol pistol = new Pistol();
        Mortar mortar = new Mortar();
        RPG rPG = new RPG();
        ShotGun shotGun = new ShotGun();
        List<UserControl> users = new List<UserControl>();
        int i = 2;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            i = Convert.ToInt32(e.KeyChar.ToString());
            if (i >= 1 && i < 7)
            {
                ValueDefault();
                ChangeButtonsOfScreen();
            }
            else if (i == 8)
                ChangeButtonsOfScreen();
            else
                MessageBox.Show("Select A Number Between 1 And 7");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            firearms.Add(pistol);
            firearms.Add(shotGun);
            firearms.Add(machineGun);
            firearms.Add(rPG);
            firearms.Add(mortar);
            users.Add(userControlKnifes1);
            users.Add(userControlPistol1);
            users.Add(userControlShotGun1);
            users.Add(userControlHeavyMachineGun1);
            users.Add(userControlRPG1);
            users.Add(userControlMortar1);
            users.Add(userControlNuke1);
            ChangeButtonsOfScreen();

        }

        private void btnSingleShot_Click(object sender, EventArgs e)
        {


            if (pBAmmo.Value == 0)
            {
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = @"..\..\Sound\GunEmpty.wav";
                player.Play();
            }
            else
            {
                firearms[i - 2].Fire();
                KillOrWounded();
                pBAmmo.Value = firearms[i - 2].Mag;
            }
        }


        
        private void btnCut_Click(object sender, EventArgs e)
        {
            if (knife.Durability > 0)
            {
                knife.Cut();
                KillOrWounded();
            }
            else
                MessageBox.Show("It's Not Sharp Son!.You Can't Cut Even An Apple." );
        }

        private void btnSharpen_Click(object sender, EventArgs e)
        {
            if (knife.Durability < knife.MaxDurability)
                knife.Sharpening();
            else
                MessageBox.Show("Enough!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (firearms[i - 2].Mag != firearms[i - 2].MaxMagSize)
            {
                firearms[i - 2].Reload();
                pBAmmo.Maximum=firearms[i - 2].MaxMagSize;
                pBAmmo.Value = firearms[i - 2].Mag;
            }
            else
                MessageBox.Show("It's Just Reloaded");
        }
        private void btnSemi_Click(object sender, EventArgs e)
        {
            if (machineGun.Mag >= 3)
            {
                machineGun.SemiAuto();
                pBAmmo.Value = machineGun.Mag;
                KillOrWounded();
            }
            else
                MessageBox.Show("Not Enough Ammo");

        }
        private void btnFull_Click(object sender, EventArgs e)
        {
            if (machineGun.Mag == machineGun.MaxMagSize)
            {
                machineGun.FullAuto();
                pBAmmo.Value = machineGun.Mag;
                HighChanceToKill();
            }
            else
                MessageBox.Show("Not Enough Ammo");
        }


        #region NonFirearmVisible
        public void NonFirearmVisible()
        {
            gBFirearms.Visible = false;
            gBNonFire.Visible = true;
            gBAmmo.Visible = false;
        }
        #endregion

        #region FirearmVisible
        public void FirearmGBVisible()
        {
            gBFirearms.Visible = true;
            gBNonFire.Visible = false;
            gBAmmo.Visible = true;
        }
        #endregion

        #region NoFireMod
        public void ForNoMod()
        {
            foreach (Button item in gBFirearms.Controls)
            {
                if (item == btnFull || item == btnSemi)
                    item.Visible = false;
                else
                    item.Visible = true;
            }
        }
        #endregion

        #region FireWithMods
        public void ForMod()
        {
            foreach (Button item in gBFirearms.Controls)
                item.Visible = true;
        }
        #endregion

        #region NukeMethod
        public void ForNuke()
        {
            gBAmmo.Visible = false;
            gBFirearms.Visible = false;
            gBNonFire.Visible = false;
            MessageBox.Show("Wrong Key Son!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Nuke nuke = new Nuke();
            nuke.Bomb();
            Application.Exit();

        }
        #endregion

        #region ChangeButtonsOfScreen
        public void ChangeButtonsOfScreen()
        {
            BringFront();
            if (i==1)
            {
                NonFirearmVisible();
            }
           if(i==4)
            {
                FirearmGBVisible();
                ForMod();
            }
            else if(i==8)
            {
                ForNuke();
            }
            else if(i==2|| i == 3 || i == 5 || i == 6)
            {
                FirearmGBVisible();
                ForNoMod();
            }
           
        }
        #endregion

        #region KillOrWounded
        void KillOrWounded()
        {
            Random rnd = new Random();
        int chance = rnd.Next(1, 3);
                if (chance == 1)
                    knife.Kill();
                else
                    knife.Wounded();
        }
        #endregion

        #region HighChanceToKill
        void HighChanceToKill()
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 4);
            if (chance <3)
                knife.Kill();
            else
                knife.Wounded();
        }

        #endregion

        #region BringFront
        void BringFront()
        {
            if(i<7)
            users[i - 1].BringToFront();
            if (i == 8)
                users[6].BringToFront();
        }
        #endregion

        void ValueDefault()
        {
           pBAmmo.Value = 0;
        }

    }
}
