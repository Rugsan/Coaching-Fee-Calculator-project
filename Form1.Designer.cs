namespace MadZooDigitalApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.memberNameLabel = new System.Windows.Forms.Label();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.membershipPeriodLabel = new System.Windows.Forms.Label();
            this.membershipPeriodComboBox = new System.Windows.Forms.ComboBox();
            this.membershipTypeLabel = new System.Windows.Forms.Label();
            this.membershipTypeComboBox = new System.Windows.Forms.ComboBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.matchesLabel = new System.Windows.Forms.Label();
            this.matchesTextBox = new System.Windows.Forms.TextBox();
            this.coachingHoursLabel = new System.Windows.Forms.Label();
            this.coachingHoursTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.headerLabel.Location = new System.Drawing.Point(50, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(430, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "MadZoo Digital Coaching Fee Calculator";
            // 
            // memberNameLabel
            // 
            this.memberNameLabel.AutoSize = true;
            this.memberNameLabel.Location = new System.Drawing.Point(50, 70);
            this.memberNameLabel.Name = "memberNameLabel";
            this.memberNameLabel.Size = new System.Drawing.Size(93, 15);
            this.memberNameLabel.TabIndex = 1;
            this.memberNameLabel.Text = "Member Name:";
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.Location = new System.Drawing.Point(200, 67);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.memberNameTextBox.TabIndex = 2;
            // 
            // membershipPeriodLabel
            // 
            this.membershipPeriodLabel.AutoSize = true;
            this.membershipPeriodLabel.Location = new System.Drawing.Point(50, 110);
            this.membershipPeriodLabel.Name = "membershipPeriodLabel";
            this.membershipPeriodLabel.Size = new System.Drawing.Size(106, 15);
            this.membershipPeriodLabel.TabIndex = 3;
            this.membershipPeriodLabel.Text = "Membership Period:";
            // 
            // membershipPeriodComboBox
            // 
            this.membershipPeriodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.membershipPeriodComboBox.FormattingEnabled = true;
            this.membershipPeriodComboBox.Location = new System.Drawing.Point(200, 107);
            this.membershipPeriodComboBox.Name = "membershipPeriodComboBox";
            this.membershipPeriodComboBox.Size = new System.Drawing.Size(200, 23);
            this.membershipPeriodComboBox.TabIndex = 4;
            this.membershipPeriodComboBox.SelectedIndexChanged += new System.EventHandler(this.membershipPeriodComboBox_SelectedIndexChanged);
            // 
            // membershipTypeLabel
            // 
            this.membershipTypeLabel.AutoSize = true;
            this.membershipTypeLabel.Location = new System.Drawing.Point(50, 150);
            this.membershipTypeLabel.Name = "membershipTypeLabel";
            this.membershipTypeLabel.Size = new System.Drawing.Size(99, 15);
            this.membershipTypeLabel.TabIndex = 5;
            this.membershipTypeLabel.Text = "Membership Type:";
            // 
            // membershipTypeComboBox
            // 
            this.membershipTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.membershipTypeComboBox.FormattingEnabled = true;
            this.membershipTypeComboBox.Location = new System.Drawing.Point(200, 147);
            this.membershipTypeComboBox.Name = "membershipTypeComboBox";
            this.membershipTypeComboBox.Size = new System.Drawing.Size(200, 23);
            this.membershipTypeComboBox.TabIndex = 6;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(50, 190);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(79, 15);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Weight (kg):";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(200, 187);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(200, 23);
            this.weightTextBox.TabIndex = 8;
            // 
            // matchesLabel
            // 
            this.matchesLabel.AutoSize = true;
            this.matchesLabel.Location = new System.Drawing.Point(50, 230);
            this.matchesLabel.Name = "matchesLabel";
            this.matchesLabel.Size = new System.Drawing.Size(124, 15);
            this.matchesLabel.TabIndex = 9;
            this.matchesLabel.Text = "Number of Matches:";
            // 
            // matchesTextBox
            // 
            this.matchesTextBox.Location = new System.Drawing.Point(200, 227);
            this.matchesTextBox.Name = "matchesTextBox";
            this.matchesTextBox.Size = new System.Drawing.Size(200, 23);
            this.matchesTextBox.TabIndex = 10;
            // 
            // coachingHoursLabel
            // 
            this.coachingHoursLabel.AutoSize = true;
            this.coachingHoursLabel.Location = new System.Drawing.Point(50, 270);
            this.coachingHoursLabel.Name = "coachingHoursLabel";
            this.coachingHoursLabel.Size = new System.Drawing.Size(97, 15);
            this.coachingHoursLabel.TabIndex = 11;
            this.coachingHoursLabel.Text = "Coaching Hours:";
            // 
            // coachingHoursTextBox
            // 
            this.coachingHoursTextBox.Location = new System.Drawing.Point(200, 267);
            this.coachingHoursTextBox.Name = "coachingHoursTextBox";
            this.coachingHoursTextBox.Size = new System.Drawing.Size(200, 23);
            this.coachingHoursTextBox.TabIndex = 12;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(200, 310);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(200, 35);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate Fee";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.outputRichTextBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.outputRichTextBox.Location = new System.Drawing.Point(50, 360);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.ReadOnly = true;
            this.outputRichTextBox.Size = new System.Drawing.Size(400, 150);
            this.outputRichTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 540);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.coachingHoursTextBox);
            this.Controls.Add(this.coachingHoursLabel);
            this.Controls.Add(this.matchesTextBox);
            this.Controls.Add(this.matchesLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.membershipTypeComboBox);
            this.Controls.Add(this.membershipTypeLabel);
            this.Controls.Add(this.membershipPeriodComboBox);
            this.Controls.Add(this.membershipPeriodLabel);
            this.Controls.Add(this.memberNameTextBox);
            this.Controls.Add(this.memberNameLabel);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MadZoo Digital App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label memberNameLabel;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.Label membershipPeriodLabel;
        private System.Windows.Forms.ComboBox membershipPeriodComboBox;
        private System.Windows.Forms.Label membershipTypeLabel;
        private System.Windows.Forms.ComboBox membershipTypeComboBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label matchesLabel;
        private System.Windows.Forms.TextBox matchesTextBox;
        private System.Windows.Forms.Label coachingHoursLabel;
        private System.Windows.Forms.TextBox coachingHoursTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
    }
}
