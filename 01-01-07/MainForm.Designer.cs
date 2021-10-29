namespace _01_01_07
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
        private void InitializeComponent()
        {
            this.ClassesListBox = new System.Windows.Forms.ListBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClassesListBox
            // 
            this.ClassesListBox.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassesListBox.FormattingEnabled = true;
            this.ClassesListBox.ItemHeight = 22;
            this.ClassesListBox.Items.AddRange(new object[] {
            "1st Period - Coding II",
            "2nd Period - Ap Literature",
            "3rd Period - SDC U.S. History",
            "4th Period - Personal Finance",
            "5/6th Period - Spanish IV Honors",
            "7th Period - Biology Honors",
            "8th Period - Integrated Math 3 Honors"});
            this.ClassesListBox.Location = new System.Drawing.Point(12, 12);
            this.ClassesListBox.Name = "ClassesListBox";
            this.ClassesListBox.Size = new System.Drawing.Size(260, 158);
            this.ClassesListBox.TabIndex = 0;
            this.ClassesListBox.SelectedIndexChanged += new System.EventHandler(this.ClassesListBox_SelectedIndexChanged);
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(80, 173);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(102, 22);
            this.classLabel.TabIndex = 1;
            this.classLabel.Text = "Class Selected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 281);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.ClassesListBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ClassesListBox;
        private System.Windows.Forms.Label classLabel;
    }
}

