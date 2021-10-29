using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_11
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void MainForm_Load(object sender, EventArgs e)
        {
            MainToolTip.SetToolTip(this.MainDateTimePicker, "Date and Time Picker");
            MainToolTip.SetToolTip(this.MainLinkLabel, "Visit Website");
            MainToolTip.SetToolTip(this.MainMaskedTextBox, "Masked Text Box");
            MainToolTip.SetToolTip(this.MainMonthCalendar, "Calendar");
            MainToolTip.SetToolTip(this.MainNumericUpDown, "Numeric Up & Down");
            MainToolTip.SetToolTip(this.MainRadioButton, "Radio Button");
            MainToolTip.SetToolTip(this.RadioButton2, "Radio Button");
            MainToolTip.SetToolTip(this.MainGroupBox, "Group Box");
            Label2.Text = "mm/dd/yyyy";
            Label3.Text = "mm/dd/yyyy";
            // MainMaskedTextBox.Mask = "00/00/0000";
            MainMaskedTextBox.MaskInputRejected += new MaskInputRejectedEventHandler(MainMaskedTextBox_MaskInputRejected);
            MainMaskedTextBox.KeyDown += new KeyEventHandler(MainMaskedTextBox_KeyDown);
            MainDateTimePicker.MinDate = new DateTime(2000, 12, 31);
            MainDateTimePicker.MaxDate = DateTime.Today;
            MainMonthCalendar.MinDate = new DateTime(2000, 12, 31);
            MainMonthCalendar.MaxDate = DateTime.Today;
            MainLabel.Text = "";
            Label1.Text = "Minimum Date: " + MainDateTimePicker.MinDate.ToShortDateString() + "\nMaximum Date: Today (" + MainDateTimePicker.MaxDate + ")";
            Label4.Text = "Minimum Date: " + MainMonthCalendar.MinDate.ToShortDateString() + "\nMaximum Date: Today (" + MainMonthCalendar.MaxDate + ")";
        }
        void MainMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (MainMaskedTextBox.MaskFull)
            {
                MainToolTip.ToolTipTitle = "Input Rejected - Too Much Data";
                MainToolTip.Show("You cannot enter any more data into the data field. Delete some characters to do so.", MainMaskedTextBox, 0, -20, 5000);
            }
            else if (e.Position == MainMaskedTextBox.Mask.Length)
            {
                MainToolTip.ToolTipTitle = "Input Rejected - End of Field";
                MainToolTip.Show("You cannot add extra characters to the end of this date field.", MainMaskedTextBox, 0, -20, 5000);
            }
            else
            {
                MainToolTip.ToolTipTitle = "Input Rejected - End of Field";
                MainToolTip.Show("You cannot add extra characters to the end of this date field.", MainMaskedTextBox, 0, -20, 5000);
            }
        }
        void MainMaskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            MainToolTip.Hide(MainMaskedTextBox);
        }
        private void MainLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.carebears.com/");
        }

        private void MainRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb1 = sender as RadioButton;

            if (rb1 == null) {
                MainLabel.Text = "Sender is not a radiobutton";
            }

            if (rb1.Checked) {
                RadioButton selectedrb = rb1;
                MainLabel.Text = "Correct!";
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb2 = sender as RadioButton;

            if (rb2 == null)
            {
                MainLabel.Text = "Sender is not a radiobutton";
            }
            if (rb2.Checked)
            {
                RadioButton selectedrb = rb2;
                MainLabel.Text = "Close the application...";
            }
        }

        private void MainDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            string date = MainDateTimePicker.Value.ToShortDateString();
            Label2.Text = date;
        }

        private void MainMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date2 = MainMonthCalendar.SelectionRange.Start.ToLongDateString();
            Label3.Text = date2;
        }
    }
}
