using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            textBox1.Text = "No items in cart";
            label3.Text = "Cost: 0";
        }
  
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                int cost = 0;
                string s = "";
                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    int found = checkedListBox1.CheckedItems[x].ToString().IndexOf('$');
                    s = s + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + Environment.NewLine;
                    cost = cost + Int32.Parse(checkedListBox1.CheckedItems[x].ToString().Substring(found + 1));
                    label3.Text = "Cost: " + cost.ToString();  
                }
                double taxCost = cost * 1.0975;
                textBox1.Text = s;
                label1.Text = taxCost.ToString();
                return;
            }
            else { textBox1.Text = "No items in cart\n"; label3.Text = "Cost: 0"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                MessageBox.Show(textBox1.Text);
                //MessageBox.Show(taxCost.ToString());
            }
            else { MessageBox.Show("Empty Cart"); }
        }
    }
}
