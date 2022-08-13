using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMeGame
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            Timer();
            InitializeComponent();
        }

        //Objects of other class
        ScoreBoard sb = new ScoreBoard();
        NameAndAgeInputForm nf = new NameAndAgeInputForm();

        //Variables 
        private Int32 score = 0;
        private  Int32 missClicks = 0;

        
        Random random = new Random();

        Timer timer = new Timer { Interval = 2000 };
        private void Timer()
        {
            timer.Enabled = true;    
            timer.Tick += new System.EventHandler(OnTimeEvent);
        }
        
        private void GameOverReset()
        {
            MessageBox.Show("Your score is :" + score);
            score = 0;
            missClicks = 0;
            firstLife.Visible = true;
            secLife.Visible = true;
            thirdLife.Visible = true;
        }

        //Database Object
        ScoreInfo si = new ScoreInfo();
        private void SavingPlayerData()
        {
            si.Name = nf.GetName();
            si.Age = nf.GetAge();
        }

        StartForm sf = new StartForm();
        private void OnTimeEvent(Object source,EventArgs e)
        {
            if(missClicks==10)
            {
                timer.Stop();
                this.Visible = false;
                GameOverReset();
                sf.Visible = true;
            }
           if(score>10)
            {
                timer.Interval = 1500;
            }
           if(score>20)
            {
                timer.Interval = 1000;
            }
           if(score>30)
            {
                timer.Interval = 700;
            }
            jerry.Location = new Point(random.Next(500), random.Next(270));
        }
       

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            missClicks++;
            if(missClicks==3)
            {
                firstLife.Visible = false;
            }
            if(missClicks==6)
            {
                secLife.Visible = false;
            }
            if(missClicks==10)
            {
                thirdLife.Visible = false;
            }
            Console.Beep();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void jerry_MouseClick(object sender, MouseEventArgs e)
        {
            jerry.Location = new Point(random.Next(500), random.Next(270));
            score++;
            scoreLabel.Text = score.ToString();
        }
    }
}
