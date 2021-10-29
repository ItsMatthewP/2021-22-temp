namespace _01_01_10
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("McCarter, Logan");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ornelas, Daniel");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Students", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CTE-IT-01");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("CTE-IT-02");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Computers", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.MainImageList = new System.Windows.Forms.ImageList(this.components);
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // MainImageList
            // 
            this.MainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainImageList.ImageStream")));
            this.MainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainImageList.Images.SetKeyName(0, "AddButton_16x.png");
            // 
            // MainTreeView
            // 
            this.MainTreeView.ImageIndex = 0;
            this.MainTreeView.ImageList = this.MainImageList;
            this.MainTreeView.Location = new System.Drawing.Point(12, 12);
            this.MainTreeView.Name = "MainTreeView";
            treeNode1.Name = "StudentNode01";
            treeNode1.Text = "McCarter, Logan";
            treeNode2.Name = "StudentNode02";
            treeNode2.Text = "Ornelas, Daniel";
            treeNode3.Name = "StudentsNode";
            treeNode3.Text = "Students";
            treeNode4.Name = "ComputerNode01";
            treeNode4.Text = "CTE-IT-01";
            treeNode5.Name = "ComputerNode02";
            treeNode5.Text = "CTE-IT-02";
            treeNode6.Name = "ComputersNode";
            treeNode6.Text = "Computers";
            this.MainTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.MainTreeView.SelectedImageIndex = 0;
            this.MainTreeView.ShowLines = false;
            this.MainTreeView.Size = new System.Drawing.Size(210, 444);
            this.MainTreeView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 468);
            this.Controls.Add(this.MainTreeView);
            this.Name = "MainForm";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList MainImageList;
        private System.Windows.Forms.TreeView MainTreeView;
    }
}

