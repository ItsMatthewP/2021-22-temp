using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_04
{
    public partial class MainForm : Form
    {

        int numberOfClicks = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        //The form's load event
        private void MainForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void ClickMe_Click(object sender, EventArgs e)
        {
            numberOfClicks++;
            Text = numberOfClicks.ToString();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Text = FormNameTextBox.Text;
        }
    }
}
