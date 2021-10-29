using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_03
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //event handler that executes when button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            MessageBox.Show("Hi " + name);
        }
    }
}
