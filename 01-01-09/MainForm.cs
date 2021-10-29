using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_09
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainLabel.Text = "";
            MainComboBox.Items.Clear();
            USState tn = new USState();
            tn.StateName = "Tennessee";
            USState az = new USState();
            az.StateName = "Arizona";
            USState tx = new USState();
            tx.StateName = "Texas";
            MainComboBox.Items.Add(tn);
            MainComboBox.Items.Add(az);
            MainComboBox.Items.Add(tx);
        }

        private void ShowItemButton_Click(object sender, EventArgs e)
        {
            if (MainComboBox.SelectedItem == null)
            {
                return;
            }
            else
            {
                MainLabel.Text = MainComboBox.SelectedItem.ToString();
            }
        }

        private void MainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MainLabel.Text = MainComboBox.SelectedItem.ToString();
        }

        private void MainLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainLabel.Text = "ya muda";
        }
    }

    class USState
    {
        public string StateName { get; set; }

        public override string ToString()
        {
            return StateName;
        }
    }

}
