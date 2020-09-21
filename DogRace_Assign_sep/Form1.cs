using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace_Assign_sep
{
    public partial class Form1 : Form
    {
        //global variable 
        String betName = "";
        int sukh = 100, baljeet = 100, manreet = 100;
        int Sukhflag = 0, Balflag = 0, Manflag = 0;
        int dog = 0;
        int winnerDog = 0;
        //create the instance of the class
        Runner obj = new Runner();

        Sukh sukhman = new Sukh();
        Baljeet bljeet = new Baljeet();
        Manreet mnreet = new Manreet();


        public Form1()
        {
            InitializeComponent();

            //this  loop is used to add the value in the drop down to set the bet amount 
            for (int x=1;x<=50;x++) {
                Bet_selecter.Items.Add("" + x);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;

        }

        private void better_sukh_CheckedChanged(object sender, EventArgs e)
        {
            //this code is used when sukh is chosed for the bet 
            if (better_sukh.Checked==true) {
                better_manreet.Checked = false;
                better_baljeet.Checked = false;
                betName = "Sukh";
            }


        }

        private void better_manreet_CheckedChanged(object sender, EventArgs e)
        {
            //this code is used when sukh is chosed for the bet 
            if (better_manreet.Checked == true)
            {
                better_sukh.Checked = false;
                better_baljeet.Checked = false;
                betName = "Man";
            }
        }

        private void better_baljeet_CheckedChanged(object sender, EventArgs e)
        {
            //this code is used when baljeet is chosed for the bet 
            if (better_baljeet.Checked == true)
            {
                better_manreet.Checked = false;
                better_sukh.Checked = false;
                betName = "Bal";
            }

        }

        private void _dog1_CheckedChanged(object sender, EventArgs e)
        {
            //code for the selection of the dog
            if (_dog1.Checked==true) {
                dog = 1;
                _dog2.Checked = false;
                _dog3.Checked = false;
                _dog4.Checked = false;
            }
        }

        private void _dog2_CheckedChanged(object sender, EventArgs e)
        {
            //code for the selection of the dog
            if (_dog2.Checked == true)
            {
                dog = 2;
                _dog1.Checked = false;
                _dog3.Checked = false;
                _dog4.Checked = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //run the dog from one location to another to prticipate in the game 
            pictureBox1.Left += obj.jumpLength();
            pictureBox2.Left += obj.jumpLength();
            pictureBox3.Left += obj.jumpLength();
            pictureBox4.Left += obj.jumpLength();
          //  run_btn.Text = "" + pictureBox1.Left;
            //check the winner 
            if (pictureBox1.Left>=410) {
                timer1.Stop();
                timer1.Enabled = false;
                winnerDog = 1;
                MessageBox.Show("1");
                result();
            }

            if (pictureBox2.Left >= 410)
            {
                timer1.Stop();
                timer1.Enabled = false;
                winnerDog = 2;
                MessageBox.Show("2");
                result();
            }

            if (pictureBox3.Left >= 410)
            {
                timer1.Stop();
                timer1.Enabled = false;
                winnerDog = 3;
                MessageBox.Show("3");
                result();
            }

            if (pictureBox4.Left >= 410)
            {
                timer1.Stop();
                timer1.Enabled = false;
                winnerDog = 4;
                MessageBox.Show("4");
                result();
            }
        }

        // check the result of the game at the last
        public void result() {
            if (Sukhflag==1) {

                sukh = sukhman.checkResult(winnerDog);
                MessageBox.Show("Sukhman has $" + sukh);
            }
            if (Balflag==1) {
                baljeet = bljeet.checkResult(winnerDog);
                MessageBox.Show("Baljeet has $" + baljeet);
            }
            if (Manflag==1) {
                manreet = mnreet.checkResult(winnerDog);
                MessageBox.Show("Manreet has $" + manreet);
            }
            
            winnerDog = 0;
            pictureBox1.Left = 17;
            pictureBox2.Left = 17;
            pictureBox3.Left = 17;
            pictureBox4.Left = 17;
            Sukhflag = 0;
            Manflag = 0;
            Balflag = 0;
            reset();
           
            
            
        }

        //reset the boxes
        public void reset() {
            dog = 0;
            _dog1.Checked = false;
            _dog2.Checked = false;
            _dog3.Checked = false;
            _dog4.Checked = false;
            better_baljeet.Checked = false;
            better_sukh.Checked = false;
            better_manreet.Checked = false;
            Bet_selecter.Text = "";
            
            betName = "";
        }

        private void bet_lock_btn_Click(object sender, EventArgs e)
        {
            //check the player is selected or not 
            if (betName.Equals("Sukh") && dog > 0 && Convert.ToInt32(Bet_selecter.Text.ToString()) < sukh)
            {
                sukhman = new Sukh(sukh, dog, Convert.ToInt32(Bet_selecter.Text));
                Sukhflag = 1;
                MessageBox.Show("Sukh set the Bet on " + dog);
            }
            else if (betName.Equals("Bal") && dog > 0 && Convert.ToInt32(Bet_selecter.Text.ToString()) < baljeet)
            {
                bljeet = new Baljeet(baljeet, dog, Convert.ToInt32(Bet_selecter.Text));
                Balflag = 1;
                MessageBox.Show("Baljeet set the Bet on " + dog);
            }
            else if (betName.Equals("Man") && dog > 0 && Convert.ToInt32(Bet_selecter.Text.ToString()) < manreet)
            {
                mnreet = new Manreet(manreet, dog, Convert.ToInt32(Bet_selecter.Text));
                Manflag = 1;
                MessageBox.Show("Manreet set the Bet on " + dog);
            }
            else {
                MessageBox.Show("Check the format to play the game or budget and wallet ");
            }
            reset();
        }

        private void _dog3_CheckedChanged(object sender, EventArgs e)
        {
            //code for the selection of the dog
            if (_dog3.Checked == true)
            {
                dog = 3;
                _dog2.Checked = false;
                _dog4.Checked = false;
                _dog1.Checked = false;
            }
        }

        private void _dog4_CheckedChanged(object sender, EventArgs e)
        {
            //code for the selection of the dog
            if (_dog4.Checked == true)
            {
                dog = 4;
                _dog1.Checked = false;
                _dog2.Checked = false;
                _dog3.Checked = false;
            }
        }
    }
}
