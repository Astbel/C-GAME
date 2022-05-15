using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        //變數
        bool MoveRight, MoveLeft, MoveUp, MoveDown;

        int speed = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game_Start_Inital();
            Point location = Player.Location;
            Console.WriteLine(location.ToString());
            //timer1.Start();
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            //this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
        }

        private void Timer_Event(object sender, EventArgs e)
        {
            Point location = Player.Location;
            Console.WriteLine(location.ToString());
            if (MoveLeft == true && Player.Left > 0)
            {
                Player.Left -= speed;
            }
            if (MoveRight == true && Player.Right < 818)
            {
                Player.Left += speed;
            }
            if (MoveUp == true && Player.Top > 0)
            {
                Player.Top -= speed;
            }
            if (MoveDown == true && Player.Bottom < 497)
            {
                Player.Top += speed;
            }
        }
        //Method
        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = true;
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown = false;
            }
        }

        //遊戲開始時初始化
        private void Game_Start_Inital()
        {
            Ghost.Visible = false;
            Boss.Visible = false;
            Blue_Poition.Visible = false;
            Red_Poition.Visible = false;
            Axe.Visible = false;
            Bow.Visible = false;
            Sword.Visible = false; 
            Item_Blue_Poition.Visible=false;
            Item_red_potion.Visible=false;
            Item_Axe.Visible=false;
            Item_Bow.Visible=false;
            Item_Sword.Visible=false;
        }
    }
}
