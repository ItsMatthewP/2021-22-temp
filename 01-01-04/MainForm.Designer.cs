namespace _01_01_04
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
            this.FormName = new System.Windows.Forms.Label();
            this.FormNameTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ClickMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormName
            // 
            this.FormName.AutoSize = true;
            this.FormName.Location = new System.Drawing.Point(41, 21);
            this.FormName.Name = "FormName";
            this.FormName.Size = new System.Drawing.Size(67, 13);
            this.FormName.TabIndex = 0;
            this.FormName.Text = "Form Name?";
            // 
            // FormNameTextBox
            // 
            this.FormNameTextBox.Location = new System.Drawing.Point(24, 37);
            this.FormNameTextBox.Name = "FormNameTextBox";
            this.FormNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FormNameTextBox.TabIndex = 1;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(130, 38);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(78, 20);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ClickMe
            // 
            this.ClickMe.Location = new System.Drawing.Point(33, 63);
            this.ClickMe.Name = "ClickMe";
            this.ClickMe.Size = new System.Drawing.Size(75, 23);
            this.ClickMe.TabIndex = 3;
            this.ClickMe.Text = "Click Me";
            this.ClickMe.UseVisualStyleBackColor = true;
            this.ClickMe.Click += new System.EventHandler(this.ClickMe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 197);
            this.Controls.Add(this.ClickMe);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.FormNameTextBox);
            this.Controls.Add(this.FormName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormName;
        private System.Windows.Forms.TextBox FormNameTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button ClickMe;
    }
}

