using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TreeNode chairsNode = MainTreeView.Nodes.Add("Chairs");
            chairsNode.Nodes.Add("Chair 01");
            chairsNode.Nodes.Add("Chair 02");
            TreeNode computersNode = MainTreeView.Nodes[1];
            for (int i = 0; i <= 25; i++) {
                computersNode.Nodes.Add("CTE-IT-" + i);
            }
        }
    }
}
