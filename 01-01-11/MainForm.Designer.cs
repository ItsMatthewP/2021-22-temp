namespace _01_01_11
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MainLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MainMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MainMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.MainNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MainRadioButton = new System.Windows.Forms.RadioButton();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.MainLabel = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainNumericUpDown)).BeginInit();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDateTimePicker
            // 
            this.MainDateTimePicker.Location = new System.Drawing.Point(12, 12);
            this.MainDateTimePicker.Name = "MainDateTimePicker";
            this.MainDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.MainDateTimePicker.TabIndex = 0;
            this.MainDateTimePicker.ValueChanged += new System.EventHandler(this.MainDateTimePicker_ValueChanged);
            // 
            // MainLinkLabel
            // 
            this.MainLinkLabel.AutoSize = true;
            this.MainLinkLabel.Location = new System.Drawing.Point(12, 39);
            this.MainLinkLabel.Name = "MainLinkLabel";
            this.MainLinkLabel.Size = new System.Drawing.Size(56, 13);
            this.MainLinkLabel.TabIndex = 1;
            this.MainLinkLabel.TabStop = true;
            this.MainLinkLabel.Text = "CareBears";
            this.MainLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainLinkLabel_LinkClicked);
            // 
            // MainMaskedTextBox
            // 
            this.MainMaskedTextBox.Location = new System.Drawing.Point(13, 56);
            this.MainMaskedTextBox.Mask = "(999) 000-0000";
            this.MainMaskedTextBox.Name = "MainMaskedTextBox";
            this.MainMaskedTextBox.Size = new System.Drawing.Size(80, 20);
            this.MainMaskedTextBox.TabIndex = 2;
            // 
            // MainMonthCalendar
            // 
            this.MainMonthCalendar.Location = new System.Drawing.Point(13, 83);
            this.MainMonthCalendar.MaxSelectionCount = 1;
            this.MainMonthCalendar.Name = "MainMonthCalendar";
            this.MainMonthCalendar.TabIndex = 3;
            this.MainMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MainMonthCalendar_DateChanged);
            // 
            // MainNumericUpDown
            // 
            this.MainNumericUpDown.Location = new System.Drawing.Point(13, 254);
            this.MainNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.MainNumericUpDown.Name = "MainNumericUpDown";
            this.MainNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MainNumericUpDown.TabIndex = 4;
            // 
            // MainRadioButton
            // 
            this.MainRadioButton.AutoSize = true;
            this.MainRadioButton.Location = new System.Drawing.Point(6, 15);
            this.MainRadioButton.Name = "MainRadioButton";
            this.MainRadioButton.Size = new System.Drawing.Size(52, 17);
            this.MainRadioButton.TabIndex = 5;
            this.MainRadioButton.TabStop = true;
            this.MainRadioButton.Text = "Apple";
            this.MainRadioButton.UseVisualStyleBackColor = true;
            this.MainRadioButton.CheckedChanged += new System.EventHandler(this.MainRadioButton_CheckedChanged);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.RadioButton2);
            this.MainGroupBox.Controls.Add(this.MainRadioButton);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 284);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(81, 54);
            this.MainGroupBox.TabIndex = 6;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Choose";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(6, 35);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(61, 17);
            this.RadioButton2.TabIndex = 6;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Android";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Location = new System.Drawing.Point(99, 308);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(28, 13);
            this.MainLabel.TabIndex = 7;
            this.MainLabel.Text = "Test";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(227, 16);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 13);
            this.Label2.TabIndex = 7;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(252, 96);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(28, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Test";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(320, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 9;
            this.Label1.Text = "Label1";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(252, 141);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 13);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "Label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 359);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.MainNumericUpDown);
            this.Controls.Add(this.MainMonthCalendar);
            this.Controls.Add(this.MainMaskedTextBox);
            this.Controls.Add(this.MainLinkLabel);
            this.Controls.Add(this.MainDateTimePicker);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Controls";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainNumericUpDown)).EndInit();
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker MainDateTimePicker;
        private System.Windows.Forms.LinkLabel MainLinkLabel;
        private System.Windows.Forms.MaskedTextBox MainMaskedTextBox;
        private System.Windows.Forms.MonthCalendar MainMonthCalendar;
        private System.Windows.Forms.NumericUpDown MainNumericUpDown;
        private System.Windows.Forms.RadioButton MainRadioButton;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label4;
    }
}

