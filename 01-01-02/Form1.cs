using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1(object sender, EventArgs e)
        {
            int number = Int32.Parse(AnswerTextBox2.Text);

            //To determine if any number is odd or even our
            //algorithm should determine if it is equally
            //divisble by 2
            if (number % 2 == 0)
            {
                AnswerTextBox2.Text = "Your number is even";
            }
            else {
                AnswerTextBox2.Text = "Your number is odd";
            }
        }

        private void AnswerTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
