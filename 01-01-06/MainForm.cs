using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_06
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(MainTextBox.Text);

            //Text property stores a String object...
            //Objectes have properties, method, event
            //String objects have properties, methods, and events
            //char name[10] = "Matt";
            //printf("Name is %s\n", name);

            string txt = MainTextBox.Text;
            MessageBox.Show(txt.ToUpper());
        }
    }
}
