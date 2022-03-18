namespace Armory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pBAmmo = new System.Windows.Forms.ProgressBar();
            this.gBNonFire = new System.Windows.Forms.GroupBox();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.gBFirearms = new System.Windows.Forms.GroupBox();
            this.btnFull = new System.Windows.Forms.Button();
            this.btnSemi = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnSingleShot = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBAmmo = new System.Windows.Forms.GroupBox();
            this.userControlKnifes1 = new Armory.UserControlKnifes();
            this.userControlMortar1 = new Armory.UserControlMortar();
            this.userControlRPG1 = new Armory.UserControlRPG();
            this.userControlShotGun1 = new Armory.UserControlShotGun();
            this.userControlHeavyMachineGun1 = new Armory.UserControlHeavyMachineGun();
            this.userControlNuke1 = new Armory.UserControlNuke();
            this.userControlPistol1 = new Armory.UserControlPistol();
            this.gBNonFire.SuspendLayout();
            this.gBFirearms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBAmmo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBAmmo
            // 
            this.pBAmmo.ForeColor = System.Drawing.Color.Lime;
            this.pBAmmo.Location = new System.Drawing.Point(129, 19);
            this.pBAmmo.Maximum = 15;
            this.pBAmmo.Name = "pBAmmo";
            this.pBAmmo.Size = new System.Drawing.Size(185, 42);
            this.pBAmmo.Step = 1;
            this.pBAmmo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBAmmo.TabIndex = 6;
            // 
            // gBNonFire
            // 
            this.gBNonFire.Controls.Add(this.btnSharpen);
            this.gBNonFire.Controls.Add(this.btnCut);
            this.gBNonFire.Location = new System.Drawing.Point(13, 554);
            this.gBNonFire.Name = "gBNonFire";
            this.gBNonFire.Size = new System.Drawing.Size(125, 100);
            this.gBNonFire.TabIndex = 7;
            this.gBNonFire.TabStop = false;
            this.gBNonFire.Text = "Non Firearms";
            // 
            // btnSharpen
            // 
            this.btnSharpen.Location = new System.Drawing.Point(6, 59);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(91, 23);
            this.btnSharpen.TabIndex = 2;
            this.btnSharpen.Text = "Sharpen";
            this.btnSharpen.UseVisualStyleBackColor = true;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(6, 21);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(91, 23);
            this.btnCut.TabIndex = 1;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // gBFirearms
            // 
            this.gBFirearms.Controls.Add(this.btnFull);
            this.gBFirearms.Controls.Add(this.btnSemi);
            this.gBFirearms.Controls.Add(this.btnReload);
            this.gBFirearms.Controls.Add(this.btnSingleShot);
            this.gBFirearms.Location = new System.Drawing.Point(159, 556);
            this.gBFirearms.Name = "gBFirearms";
            this.gBFirearms.Size = new System.Drawing.Size(226, 98);
            this.gBFirearms.TabIndex = 8;
            this.gBFirearms.TabStop = false;
            this.gBFirearms.Text = "Firearms";
            // 
            // btnFull
            // 
            this.btnFull.Location = new System.Drawing.Point(129, 57);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(91, 23);
            this.btnFull.TabIndex = 3;
            this.btnFull.Text = "FullAuto";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // btnSemi
            // 
            this.btnSemi.Location = new System.Drawing.Point(129, 19);
            this.btnSemi.Name = "btnSemi";
            this.btnSemi.Size = new System.Drawing.Size(91, 23);
            this.btnSemi.TabIndex = 2;
            this.btnSemi.Text = "Semi-Auto";
            this.btnSemi.UseVisualStyleBackColor = true;
            this.btnSemi.Click += new System.EventHandler(this.btnSemi_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 57);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(91, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnSingleShot
            // 
            this.btnSingleShot.Location = new System.Drawing.Point(15, 19);
            this.btnSingleShot.Name = "btnSingleShot";
            this.btnSingleShot.Size = new System.Drawing.Size(91, 23);
            this.btnSingleShot.TabIndex = 0;
            this.btnSingleShot.Text = "Single Shot";
            this.btnSingleShot.UseVisualStyleBackColor = true;
            this.btnSingleShot.Click += new System.EventHandler(this.btnSingleShot_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Armory.Properties.Resources.ammo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // gBAmmo
            // 
            this.gBAmmo.Controls.Add(this.pBAmmo);
            this.gBAmmo.Controls.Add(this.pictureBox1);
            this.gBAmmo.Location = new System.Drawing.Point(468, 556);
            this.gBAmmo.Name = "gBAmmo";
            this.gBAmmo.Size = new System.Drawing.Size(320, 80);
            this.gBAmmo.TabIndex = 11;
            this.gBAmmo.TabStop = false;
            // 
            // userControlKnifes1
            // 
            this.userControlKnifes1.Location = new System.Drawing.Point(-2, -2);
            this.userControlKnifes1.Name = "userControlKnifes1";
            this.userControlKnifes1.Size = new System.Drawing.Size(811, 549);
            this.userControlKnifes1.TabIndex = 10;
            // 
            // userControlMortar1
            // 
            this.userControlMortar1.Location = new System.Drawing.Point(1, 1);
            this.userControlMortar1.Name = "userControlMortar1";
            this.userControlMortar1.Size = new System.Drawing.Size(808, 546);
            this.userControlMortar1.TabIndex = 5;
            // 
            // userControlRPG1
            // 
            this.userControlRPG1.Location = new System.Drawing.Point(1, 1);
            this.userControlRPG1.Name = "userControlRPG1";
            this.userControlRPG1.Size = new System.Drawing.Size(808, 546);
            this.userControlRPG1.TabIndex = 4;
            // 
            // userControlShotGun1
            // 
            this.userControlShotGun1.Location = new System.Drawing.Point(1, -2);
            this.userControlShotGun1.Name = "userControlShotGun1";
            this.userControlShotGun1.Size = new System.Drawing.Size(811, 549);
            this.userControlShotGun1.TabIndex = 3;
            // 
            // userControlHeavyMachineGun1
            // 
            this.userControlHeavyMachineGun1.Location = new System.Drawing.Point(4, 1);
            this.userControlHeavyMachineGun1.Name = "userControlHeavyMachineGun1";
            this.userControlHeavyMachineGun1.Size = new System.Drawing.Size(808, 546);
            this.userControlHeavyMachineGun1.TabIndex = 2;
            // 
            // userControlNuke1
            // 
            this.userControlNuke1.Location = new System.Drawing.Point(4, 1);
            this.userControlNuke1.Name = "userControlNuke1";
            this.userControlNuke1.Size = new System.Drawing.Size(808, 546);
            this.userControlNuke1.TabIndex = 1;
            // 
            // userControlPistol1
            // 
            this.userControlPistol1.Location = new System.Drawing.Point(5, 1);
            this.userControlPistol1.Name = "userControlPistol1";
            this.userControlPistol1.Size = new System.Drawing.Size(811, 549);
            this.userControlPistol1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 709);
            this.Controls.Add(this.gBAmmo);
            this.Controls.Add(this.userControlKnifes1);
            this.Controls.Add(this.gBFirearms);
            this.Controls.Add(this.gBNonFire);
            this.Controls.Add(this.userControlMortar1);
            this.Controls.Add(this.userControlRPG1);
            this.Controls.Add(this.userControlShotGun1);
            this.Controls.Add(this.userControlHeavyMachineGun1);
            this.Controls.Add(this.userControlNuke1);
            this.Controls.Add(this.userControlPistol1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.gBNonFire.ResumeLayout(false);
            this.gBFirearms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBAmmo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlPistol userControlPistol1;
        private UserControlNuke userControlNuke1;
        private UserControlHeavyMachineGun userControlHeavyMachineGun1;
        private UserControlShotGun userControlShotGun1;
        private UserControlRPG userControlRPG1;
        private UserControlMortar userControlMortar1;
        private System.Windows.Forms.ProgressBar pBAmmo;
        private System.Windows.Forms.GroupBox gBNonFire;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.GroupBox gBFirearms;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnSemi;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSingleShot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControlKnifes userControlKnifes1;
        private System.Windows.Forms.GroupBox gBAmmo;
    }
}

