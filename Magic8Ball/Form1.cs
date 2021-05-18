using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class eightBall : Form
    {
        public eightBall()
        {
            InitializeComponent();
           
        }
        Random rng = new Random();
        private void button_Click(object sender, EventArgs e)
        {
         int randomNumber = rng.Next(1, 7);
            if (randomNumber == 1)
            {
                answerLabel.Text = "YES";
            }
            else if (randomNumber == 2)
            {
                answerLabel.Text = "NO";
            }
            else if(randomNumber == 3)
            {
                answerLabel.Text = "MAYBE";
            }
            else if(randomNumber == 4)
            {
                answerLabel.Text = "VERY LIKELY";
            }
            else if(randomNumber == 5)
            {
                answerLabel.Text = "PROBABLY NOT";
            }
            else if(randomNumber == 6)
            {
                answerLabel.Text = "I HAVE NO CLUE";
            }
        }
    }
}
