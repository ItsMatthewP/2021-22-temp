using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _01_01_12
{
    public partial class MainForm : Form
    {
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainPictureBox_Click(object sender, EventArgs e)
        {

        }
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainButton_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainPictureBox.Image = new Bitmap(openFileDialog.FileName);
                }
                //Get the path of specified file
                filePath = openFileDialog.FileName;
            }
            MainButton.Visible = false;
            this.Text = filePath;
        }

        private void MainTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {   
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                string imagedir = Path.GetDirectoryName(openFileDialog.FileName);
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                }
            }
        }
     /*   void MainTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog imagedir = new OpenFileDialog();
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string[] files = Directory.GetFiles(dir, "*.jpg; *.png; *.bmp"); //.png, bmp, etc.
        }
    */
    }
}
