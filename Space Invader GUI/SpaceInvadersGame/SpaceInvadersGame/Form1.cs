using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace SpaceInvadersGame
{    
    public partial class Game : Form
    {
        int FIreGap = 7, Gap = 0;
        int MovementSteps = 10;
        List<PictureBox> PlayerFires, Enemies, EnemiesFires;        

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timeGameLoopTimer.Enabled = true;
            PlayerFires = new List<PictureBox>();
            Enemies = new List<PictureBox>() { pbEnemy11, pbEnemy12, pbEnemy21, pbEnemy31, pbEnemy32};
        }

        private void timeGameLoopTimer_Tick(object sender, EventArgs e)
        {
            Gap++;

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                if (IsMovementPossible("Left"))
                {
                    pbPlayerShip.Left -= MovementSteps;
                }
            }

            if(Keyboard.IsKeyPressed(Key.RightArrow))
            {
                if (IsMovementPossible("Right"))
                {
                    pbPlayerShip.Left += MovementSteps;
                }
            }

            if (Gap >= FIreGap)
            {                
                if (Keyboard.IsKeyPressed(Key.Space))
                {
                    Gap = 0;
                    PictureBox pbFire = CreatePlayerLaser();
                    PlayerFires.Add(pbFire);
                    this.Controls.Add(pbFire);                    
                }
            }

            MoveBullets();
            RemoveBullets();
        }

        private bool IsMovementPossible(string Direction)
        {
            if(Direction == "Left")
            {
                if(pbPlayerShip.Left - MovementSteps >= 0 )
                {
                    return true;
                }
            }

            else if(Direction == "Right")
            {
                if (pbPlayerShip.Right + MovementSteps <  this.Width)
                {
                    return true;
                }
            }

            return false;
        }

        private PictureBox CreatePlayerLaser()
        {
            PictureBox pbFire = new PictureBox();
            Image fireImage = Properties.Resources.PlayeLaser;
            pbFire.Image = fireImage;
            pbFire.Width = fireImage.Width;
            pbFire.Height = fireImage.Height - (fireImage.Height/4);
            pbFire.BackColor = Color.Transparent;
            pbFire.Location = new System.Drawing.Point(pbPlayerShip.Left + (pbPlayerShip.Width/2)- 7, pbPlayerShip.Top - 31);
            return pbFire;
        }

        private void MoveBullets()
        {
            foreach (PictureBox bullet in PlayerFires)
            {
                bullet.Top = bullet.Top - 20;
            }
        }

        private void RemoveBullets()
        {
            foreach (PictureBox bullet in PlayerFires)
            {
                foreach(PictureBox Enemy in Enemies)
                { 
                    if(bullet.Bounds.IntersectsWith(Enemy.Bounds))
                    {
                        bullet.Hide();
                        Enemy.Hide();
                        this.Controls.Remove(Enemy);
                        Enemies.Remove(Enemy);
                        break;
                    }
                }
            }

            for (int i =0; i<PlayerFires.Count; i++)
            {
                if(PlayerFires[i].Bottom < 0)
                {
                    PlayerFires.Remove(PlayerFires[i]);
                }
            }
        }
        
    }
}
