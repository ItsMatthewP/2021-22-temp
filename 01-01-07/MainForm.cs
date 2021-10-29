using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_01_07
{
    public partial class MainForm : Form
    {
        Student s1; // variable declarations
        Student s2; // variable declarations
        Student s3; // variable declarations
        public MainForm()
        {
            InitializeComponent();
        }

        private void ClassesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            classLabel.Text = ClassesListBox.SelectedItem.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            s1 = new Student();
            s2 = new Student();
            s3 = new Student();

            s1.FirstName = "Daniel";
            s1.LastName = "Ornelas";

            s2.FirstName = "Brandon";
            s2.LastName = "Bouslog";

            s3.FirstName = "Graham";
            s3.LastName = "Wheeler";

            //Clear the list box
            ClassesListBox.Items.Clear();

            ClassesListBox.Items.Add(s1);
            ClassesListBox.Items.Add(s2);
            ClassesListBox.Items.Add(s3);
        }
    }
}
