using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euromilhões
{
    public partial class Euromilhoes : Form
    {
        public Euromilhoes()
        {
            InitializeComponent();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            //RANDOM
            Random randomNumber = new Random();
            Random randomStar = new Random();


            //NUMBERS
            int randomNumber1 = randomNumber.Next(1, 50);
            int randomNumber2 = randomNumber.Next(1, 50);
            int randomNumber3 = randomNumber.Next(1, 50);
            int randomNumber4 = randomNumber.Next(1, 50);
            int randomNumber5 = randomNumber.Next(1, 50);


            //STARS
            int randomStar1 = randomStar.Next(1, 10);
            int randomStar2 = randomStar.Next(1, 10);


            //STORE VALUES
            lbl1.Text = randomNumber1.ToString();
            lbl2.Text = randomNumber2.ToString();
            lbl3.Text = randomNumber3.ToString();
            lbl4.Text = randomNumber4.ToString();
            lbl5.Text = randomNumber5.ToString();

            lblStar1.Text = randomStar1.ToString();
            lblStar2.Text = randomStar2.ToString();


            if (txtNumber1.Text == randomNumber1.ToString() || txtNumber2.Text == randomNumber2.ToString() || txtNumber3.Text == randomNumber3.ToString() || txtNumber4.Text == randomNumber4.ToString() || txtNumber5.Text == randomNumber5.ToString())
            {
                MessageBox.Show("Congrats!!");
            }

            if (txtStar1.Text == randomStar1.ToString() || txtStar2.Text == randomStar2.ToString())
            {
                MessageBox.Show("Congrats!!");
            }
        }
    }
}
