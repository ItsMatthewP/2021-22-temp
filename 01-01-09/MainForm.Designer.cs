namespace _01_01_09
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
            this.MainComboBox = new System.Windows.Forms.ComboBox();
            this.ShowItemButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.MainLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // MainComboBox
            // 
            this.MainComboBox.FormattingEnabled = true;
            this.MainComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.MainComboBox.Location = new System.Drawing.Point(12, 12);
            this.MainComboBox.Name = "MainComboBox";
            this.MainComboBox.Size = new System.Drawing.Size(214, 21);
            this.MainComboBox.TabIndex = 0;
            this.MainComboBox.SelectedIndexChanged += new System.EventHandler(this.MainComboBox_SelectedIndexChanged);
            // 
            // ShowItemButton
            // 
            this.ShowItemButton.Location = new System.Drawing.Point(232, 11);
            this.ShowItemButton.Name = "ShowItemButton";
            this.ShowItemButton.Size = new System.Drawing.Size(75, 23);
            this.ShowItemButton.TabIndex = 1;
            this.ShowItemButton.Text = "Show";
            this.ShowItemButton.UseVisualStyleBackColor = true;
            this.ShowItemButton.Click += new System.EventHandler(this.ShowItemButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(138, 123);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(35, 13);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "label1";
            // 
            // MainLinkLabel
            // 
            this.MainLinkLabel.AutoSize = true;
            this.MainLinkLabel.Location = new System.Drawing.Point(244, 37);
            this.MainLinkLabel.Name = "MainLinkLabel";
            this.MainLinkLabel.Size = new System.Drawing.Size(48, 13);
            this.MainLinkLabel.TabIndex = 3;
            this.MainLinkLabel.TabStop = true;
            this.MainLinkLabel.Text = "Click Me";
            this.MainLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 258);
            this.Controls.Add(this.MainLinkLabel);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ShowItemButton);
            this.Controls.Add(this.MainComboBox);
            this.Name = "MainForm";
            this.Text = "01-01-09";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MainComboBox;
        private System.Windows.Forms.Button ShowItemButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.LinkLabel MainLinkLabel;
    }
}

