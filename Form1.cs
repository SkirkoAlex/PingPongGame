using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_pong_2
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 3;
        private int speed_hor = 3;
        private int score = 0;

        public Form1()
        {

            InitializeComponent();

            timer.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
          game_panel.Top = background.Bottom - (background.Bottom / 10);
            loseLibel.Visible = false;
            Pause.Visible = false;
            Res.Visible = false;
            Info.Visible = true;
            loseLibel.Left = (background.Width / 2) - (loseLibel.Width / 2);
            loseLibel.Top = (background.Height / 2) - (loseLibel.Height / 2);
            Pause.Left = (background.Width / 2) - (Pause.Width / 2);
            Pause.Top = (background.Height / 2) - (Pause.Height / 2);
            Res.Left = (background.Width / 2) - (Res.Width / 2);
            Res.Top = (background.Height/2) - 150;
            Info.Left = (background.Width / 2) - (Info.Width / 2);
            Info.Top = (background.Height - 1000);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            int speed_platform = 10;
            int bottom =  background.Bottom - (background.Bottom / 10);
            if (e.KeyCode == Keys.W && game_panel.Top >=background.Top )
                game_panel.Top -= speed_platform;
            if (e.KeyCode == Keys.S && game_panel.Bottom<bottom)
                game_panel.Top += speed_platform;
            if (e.KeyCode == Keys.D && game_panel.Right <= background.Right)
                game_panel.Left += speed_platform;
            if (e.KeyCode == Keys.A && game_panel.Left>=background.Left)
                game_panel.Left -= speed_platform;

            if (e.KeyCode == Keys.R)
            {
                game_boll.Top = 50;
                game_boll.Left = 70;
                speed_hor = 2;
                speed_vertical = 2;
                score = 0;
                loseLibel.Visible = false;
                timer.Enabled = true;
                Res.Visible = false;
                result.Text = "Результат: 0";

            }
            if (e.KeyCode == Keys.P)
            {
                timer.Enabled = false;
                game_boll.Visible = false;
                game_panel.Visible = false;
                Pause.Visible = true;
                
            }
            if (e.KeyCode == Keys.G)
            {
                timer.Enabled = true;
                game_boll.Visible = true;
                game_panel.Visible = true;
                Pause.Visible = false; ;

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            game_panel.Left = Cursor.Position.X - (game_panel.Width/2);
            game_boll.Left += speed_hor;
            game_boll.Top += speed_vertical;
            
            


            if (game_boll.Left <= background.Left)
                speed_hor *= -1;
            if (game_boll.Right >= background.Right)
                speed_hor *= -1;
            if (game_boll.Top <= background.Top)
                speed_vertical *= -1;
            if (game_boll.Bottom >= background.Bottom)
            {
                timer.Enabled = false;
                loseLibel.Visible = true;
                Res.Visible = true;
                Res.Text = $"Ваш результат: {score.ToString()}";
            };
            if (game_boll.Bottom>= game_panel.Top && game_boll.Bottom<= game_panel.Bottom 
                && game_boll.Left>=game_panel.Left && game_boll.Right<=game_panel.Right)
            {
                speed_hor += 3;
                speed_vertical += 1;
                speed_vertical *= -1;
                score++;
                result.Text = "Результат: " + score.ToString();
                

                Random randColor = new Random();
                background.BackColor = Color.FromArgb(randColor.Next(150,255), randColor.Next(150, 255), randColor.Next(150, 255));

            }
        }
    }
}
