using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogProject_Karan
{
    public partial class Form1 : Form
    {
        ValidationClass obj_validate = new ValidationClass();
        int Dog = 0;
        String Better = "";
        int[] betAmount = {100,120,150};
        int winnerDog = 0;
        

        public Form1()
        { 
            InitializeComponent();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!Better.Equals("") && Dog > 0 && obj_validate.checkNumber(txtBet))
            {
                setting();
                reset();
                btnDog1.Enabled = true;
                btnDog2.Enabled = true;
                btnDog3.Enabled = true;
                btnDog4.Enabled = true;
                btnRun.Enabled = true;
                BetterKaran.Enabled = true;
                BetterHarnoor.Enabled = true;
                betterRoshan.Enabled =true;

            }
            else {
                MessageBox.Show("check once your details for starting the race ");
            }

        }
        //store  the details of the better in the butto and display them in front of the user or player 
        public void setting() {
            if (Better.Equals("Karan") && Convert.ToInt32(txtBet.Text.ToString()) <= betAmount[0] && Convert.ToInt32(txtBet.Text.ToString()) < 51)
            {
                BetterKaran.Text = "Karan choose Dog " + Dog + " and Amount " + txtBet.Text.ToString();
                btnRun.Visible = true;
            }

            else if (Better.Equals("Roshan") && Convert.ToInt32(txtBet.Text.ToString()) <= betAmount[1] && Convert.ToInt32(txtBet.Text.ToString()) < 51)
            {
                betterRoshan.Text = "Roshan choose Dog " + Dog + " and Amount " + txtBet.Text.ToString();
                btnRun.Visible = true;
            }
            else if (Better.Equals("Harnoor") && Convert.ToInt32(txtBet.Text.ToString()) <= betAmount[2] && Convert.ToInt32(txtBet.Text.ToString()) < 51)
            {
                BetterHarnoor.Text = "Harnoor choose Dog " + Dog + " and Amount " + txtBet.Text.ToString();
                btnRun.Visible = true;
            }
            else {
                MessageBox.Show("Check your BUdget amount once for the bet you can bet only less then 50 dollar");
                btnRun.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void amountSetting() {
            if (BetterKaran.BackColor==Color.Blue) {
                String[] arr = BetterKaran.Text.ToString().Split(' ');
                if (arr.Equals(winnerDog.ToString()))
                {
                    betAmount[0] += Convert.ToInt32(arr[6]);
                }
                else {
                    betAmount[0] -= Convert.ToInt32(arr[6]);
                }
                BetterKaran.Text = betAmount[0]+ " Karan Account";

            }

            if (betterRoshan.BackColor == Color.Blue)
            {
                String[] arr = betterRoshan.Text.ToString().Split(' ');
                if (arr.Equals(winnerDog.ToString()))
                {
                    betAmount[1] += Convert.ToInt32(arr[6]);
                }
                else
                {
                    betAmount[1] -= Convert.ToInt32(arr[6]);
                }
                betterRoshan.Text = betAmount[1] + " Roshan Account";
            }

            if (BetterHarnoor.BackColor == Color.Blue)
            {
                String[] arr = BetterHarnoor.Text.ToString().Split(' ');
                if (arr.Equals(winnerDog.ToString()))
                {
                    betAmount[2] += Convert.ToInt32(arr[6]);
                }
                else
                {
                    betAmount[2] -= Convert.ToInt32(arr[6]);
                }
                BetterHarnoor.Text = betAmount[2]+" Harnoor Account";
            }
           BetterHarnoor.BackColor= Color.Gray;
          BetterKaran.BackColor = Color.Gray;
          betterRoshan.BackColor = Color.Gray;
            pictureBox1.Top = 657;
            pictureBox2.Top = 657;
            pictureBox3.Top = 657;
            pictureBox4.Top = 657;
        }

        //this code is the change the color of the button back to the original format 
        public void reset() {

            btnDog1.BackColor = Color.Gray;
            btnDog2.BackColor = Color.Gray;
            btnDog3.BackColor = Color.Gray;
            btnDog4.BackColor = Color.Gray;
          

        }
        private void btnDog1_Click(object sender, EventArgs e)
        {
            Dog = 1;
            btnDog1.BackColor = Color.Green;
            btnDog1.Enabled = false;
            btnDog2.Enabled = false;
            btnDog3.Enabled = false;
            btnDog4.Enabled = false;

        }

        private void btnDog2_Click(object sender, EventArgs e)
        {
            Dog = 2;
            btnDog2.BackColor = Color.Green;
            btnDog1.Enabled = false;
            btnDog2.Enabled = false;
            btnDog3.Enabled = false;
            btnDog4.Enabled = false;
        }

        private void btnDog3_Click(object sender, EventArgs e)
        {
            Dog = 3;
            btnDog3.BackColor = Color.Green;
            btnDog1.Enabled = false;
            btnDog2.Enabled = false;
            btnDog3.Enabled = false;
            btnDog4.Enabled = false;
        }

        private void btnDog4_Click(object sender, EventArgs e)
        {
            Dog = 4;
            btnDog4.BackColor = Color.Green;
            btnDog1.Enabled = false;
            btnDog2.Enabled = false;
            btnDog3.Enabled = false;
            btnDog4.Enabled = false;
        }

        private void BetterKaran_Click(object sender, EventArgs e)
        {
            Better = "Karan";
            BetterKaran.BackColor = Color.Blue;
            BetterKaran.Enabled = false;
            BetterHarnoor.Enabled = false;
            betterRoshan.Enabled = false;

        }

        private void betterRoshan_Click(object sender, EventArgs e)
        {
            Better = "Roshan";
            betterRoshan.BackColor = Color.Blue;
            BetterKaran.Enabled = false;
            BetterHarnoor.Enabled = false;
            betterRoshan.Enabled = false;

        }

        private void BetterHarnoor_Click(object sender, EventArgs e)
        {
            Better = "Harnoor";
            BetterHarnoor.BackColor = Color.Blue;
            BetterKaran.Enabled = false;
            BetterHarnoor.Enabled = false;
            betterRoshan.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top > 151 )
            {
                pictureBox1.Top -= obj_validate.genRandomNo();
            }
            else {
                timer1.Stop();
                MessageBox.Show("First Dog is Winner");
                winnerDog = 1;
                amountSetting();
                btnRun.Enabled = false;
            }
            if (pictureBox2.Top > 151)
            {
                pictureBox2.Top -= obj_validate.genRandomNo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Second Dog is Winner");
                winnerDog = 2;
                amountSetting();
                btnRun.Enabled = false;
            }

            if (pictureBox3.Top > 151)
            {
                pictureBox3.Top -= obj_validate.genRandomNo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Third Dog is Winner");
                winnerDog = 3;
                btnRun.Enabled = false;
                amountSetting();
            }

            if (pictureBox4.Top > 151)
            {
                pictureBox4.Top -= obj_validate.genRandomNo();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Forth Dog is Winner");
                winnerDog = 4;
                amountSetting();
                btnRun.Enabled = false;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
