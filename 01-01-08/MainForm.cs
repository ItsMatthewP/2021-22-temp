using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_08
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string trimmedText = textBox1.Text.Trim();

            if (trimmedText != "")
            {
                ListBox.Items.Add(trimmedText);

                string msg = " items";
                if (ListBox.Items.Count == 1)
                {
                    msg = " item";
                }
                Label1.Text = ListBox.Items.Count.ToString() + msg;
            }

            textBox1.Clear();
        }
    }
}