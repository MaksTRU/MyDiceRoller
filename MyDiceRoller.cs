using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiceRoller
{
    public partial class DiceRoller : Form
    {
        int sum = 0;
        int randNumber = 0;

        public DiceRoller()
        {
            InitializeComponent();
            InitializeDiceRoller();
        }

        private void InitializeDiceRoller()
        {
            buttonRoll.BackColor = Color.MediumPurple;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void DiceRoll()
        {
            Random random = new Random();
            
            try
            {
                for (int i = 0; i < Convert.ToInt32(NumbDices.Text); i++)
                {
                    //create and sum random numbers
                    randNumber = random.Next(1, Convert.ToInt32(NumbSides.Text) + 1);
                    sum += randNumber;
                    
                    //show each number
                    labelNumbers.Text += Convert.ToString(randNumber) + " ";    
                }
            }
            catch
            {
                MessageBox.Show("Wrong number. Please, try again");
            }
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {
            labelNumbers.Text = "";
            DiceRoll();
            labelResult.Text = Convert.ToString(sum);
            sum = 0;
            randNumber = 0;
        }


        //when cursor enters or leaves TextBoxes
        private void EnterOrLeaveNumbDices(object sender, EventArgs e)
        {
            if (NumbDices.Text == "")
            {
                NumbDices.Text = "write number of dice";
            }
            else if (NumbDices.Text == "write number of dice")
            {
                NumbDices.Text = "";
            }
        }

        private void EnterOrLeaveNumbSides(object sender, EventArgs e)
        {
            if (NumbSides.Text == "")
            {
                NumbSides.Text = "write number of sides";
            }
            else if (NumbSides.Text == "write number of sides")
            {
                NumbSides.Text = "";
            }
        }
    }
}
