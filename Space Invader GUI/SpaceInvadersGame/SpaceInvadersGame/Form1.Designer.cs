
namespace SpaceInvadersGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.pbPlayerShip = new System.Windows.Forms.PictureBox();
            this.timeGameLoopTimer = new System.Windows.Forms.Timer(this.components);
            this.pbEnemy11 = new System.Windows.Forms.PictureBox();
            this.pbEnemy21 = new System.Windows.Forms.PictureBox();
            this.pbEnemy32 = new System.Windows.Forms.PictureBox();
            this.pbEnemy31 = new System.Windows.Forms.PictureBox();
            this.pbEnemy12 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy12)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerShip
            // 
            this.pbPlayerShip.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayerShip.Image = global::SpaceInvadersGame.Properties.Resources.PlayerLVL1;
            this.pbPlayerShip.Location = new System.Drawing.Point(462, 550);
            this.pbPlayerShip.Name = "pbPlayerShip";
            this.pbPlayerShip.Size = new System.Drawing.Size(97, 99);
            this.pbPlayerShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerShip.TabIndex = 0;
            this.pbPlayerShip.TabStop = false;
            // 
            // timeGameLoopTimer
            // 
            this.timeGameLoopTimer.Interval = 50;
            this.timeGameLoopTimer.Tick += new System.EventHandler(this.timeGameLoopTimer_Tick);
            // 
            // pbEnemy11
            // 
            this.pbEnemy11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEnemy11.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy11.Image = global::SpaceInvadersGame.Properties.Resources.SEnemyShip1;
            this.pbEnemy11.Location = new System.Drawing.Point(54, 148);
            this.pbEnemy11.Name = "pbEnemy11";
            this.pbEnemy11.Size = new System.Drawing.Size(97, 99);
            this.pbEnemy11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy11.TabIndex = 1;
            this.pbEnemy11.TabStop = false;
            // 
            // pbEnemy21
            // 
            this.pbEnemy21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEnemy21.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy21.Image = global::SpaceInvadersGame.Properties.Resources.SEnemyShip2;
            this.pbEnemy21.Location = new System.Drawing.Point(446, 118);
            this.pbEnemy21.Name = "pbEnemy21";
            this.pbEnemy21.Size = new System.Drawing.Size(89, 86);
            this.pbEnemy21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy21.TabIndex = 2;
            this.pbEnemy21.TabStop = false;
            // 
            // pbEnemy32
            // 
            this.pbEnemy32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEnemy32.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy32.Image = global::SpaceInvadersGame.Properties.Resources.SEnemyShip3;
            this.pbEnemy32.Location = new System.Drawing.Point(166, -4);
            this.pbEnemy32.Name = "pbEnemy32";
            this.pbEnemy32.Size = new System.Drawing.Size(133, 139);
            this.pbEnemy32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy32.TabIndex = 3;
            this.pbEnemy32.TabStop = false;
            // 
            // pbEnemy31
            // 
            this.pbEnemy31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEnemy31.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy31.Image = global::SpaceInvadersGame.Properties.Resources.SEnemyShip3;
            this.pbEnemy31.Location = new System.Drawing.Point(671, -4);
            this.pbEnemy31.Name = "pbEnemy31";
            this.pbEnemy31.Size = new System.Drawing.Size(133, 139);
            this.pbEnemy31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy31.TabIndex = 4;
            this.pbEnemy31.TabStop = false;
            // 
            // pbEnemy12
            // 
            this.pbEnemy12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbEnemy12.BackColor = System.Drawing.Color.Transparent;
            this.pbEnemy12.Image = global::SpaceInvadersGame.Properties.Resources.SEnemyShip1;
            this.pbEnemy12.Location = new System.Drawing.Point(824, 148);
            this.pbEnemy12.Name = "pbEnemy12";
            this.pbEnemy12.Size = new System.Drawing.Size(97, 99);
            this.pbEnemy12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEnemy12.TabIndex = 5;
            this.pbEnemy12.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SpaceInvadersGame.Properties.Resources.BgSpsce;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pbEnemy12);
            this.Controls.Add(this.pbEnemy31);
            this.Controls.Add(this.pbEnemy32);
            this.Controls.Add(this.pbEnemy21);
            this.Controls.Add(this.pbEnemy11);
            this.Controls.Add(this.pbPlayerShip);
            this.DoubleBuffered = true;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemy12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerShip;
        private System.Windows.Forms.Timer timeGameLoopTimer;
        private System.Windows.Forms.PictureBox pbEnemy11;
        private System.Windows.Forms.PictureBox pbEnemy21;
        private System.Windows.Forms.PictureBox pbEnemy32;
        private System.Windows.Forms.PictureBox pbEnemy31;
        private System.Windows.Forms.PictureBox pbEnemy12;
    }
}

