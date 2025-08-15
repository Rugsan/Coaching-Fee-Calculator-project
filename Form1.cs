using System;
using System.Globalization;
using System.Windows.Forms;

namespace MadZooDigitalApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Populate membership periods and update types on load
        private void Form1_Load(object sender, EventArgs e)
        {
            membershipPeriodComboBox.Items.Add("Annual");
            membershipPeriodComboBox.Items.Add("6 Months");
            membershipPeriodComboBox.Items.Add("3 Months");
            membershipPeriodComboBox.Items.Add("1 Month");
            membershipPeriodComboBox.SelectedIndex = 0;
            UpdateMembershipTypeOptions();
        }

        private void membershipPeriodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMembershipTypeOptions();
        }

        // Update membership types based on selected period
        private void UpdateMembershipTypeOptions()
        {
            membershipTypeComboBox.Items.Clear();
            // Safely retrieve selected membership period; default to "Annual" if null.
            string period = membershipPeriodComboBox.SelectedItem?.ToString() ?? "Annual";

            if (period == "Annual" || period == "6 Months")
            {
                membershipTypeComboBox.Items.Add("Individual");
                membershipTypeComboBox.Items.Add("Family");
                membershipTypeComboBox.Items.Add("Junior/Intermediate");
            }
            else if (period == "3 Months" || period == "1 Month")
            {
                membershipTypeComboBox.Items.Add("Individual");
                membershipTypeComboBox.Items.Add("Family");
            }
            membershipTypeComboBox.SelectedIndex = 0;
        }

        // Calculate fees and display output
        private void calculateButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Clear();

            string memberName = memberNameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(memberName))
            {
                MessageBox.Show("Please enter the member's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                memberNameTextBox.Focus();
                return;
            }

            if (!double.TryParse(weightTextBox.Text.Trim(), out double weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a valid weight in kilograms.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                weightTextBox.Focus();
                return;
            }

            if (!int.TryParse(matchesTextBox.Text.Trim(), out int numMatches) || numMatches < 0)
            {
                MessageBox.Show("Please enter a valid number of matches played.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                matchesTextBox.Focus();
                return;
            }

            if (!int.TryParse(coachingHoursTextBox.Text.Trim(), out int coachingHours) || coachingHours < 0)
            {
                MessageBox.Show("Please enter a valid number of coaching hours.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coachingHoursTextBox.Focus();
                return;
            }
            if (coachingHours > 16)
            {
                MessageBox.Show("Coaching hours exceed the maximum allowed (16 hours per month).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                coachingHoursTextBox.Focus();
                return;
            }

            // Safely retrieve selected values; use defaults if necessary.
            string membershipPeriod = membershipPeriodComboBox.SelectedItem?.ToString() ?? "Annual";
            string membershipType = membershipTypeComboBox.SelectedItem?.ToString() ?? "Individual";

            double membershipFee = 0;
            if (membershipPeriod == "Annual")
            {
                if (membershipType == "Individual") membershipFee = 5000;
                else if (membershipType == "Family") membershipFee = 7000;
                else if (membershipType == "Junior/Intermediate") membershipFee = 3000;
            }
            else if (membershipPeriod == "6 Months")
            {
                if (membershipType == "Individual") membershipFee = 3000;
                else if (membershipType == "Family") membershipFee = 5000;
                else if (membershipType == "Junior/Intermediate") membershipFee = 2000;
            }
            else if (membershipPeriod == "3 Months")
            {
                membershipFee = (membershipType == "Individual") ? 2500 : 3500;
            }
            else if (membershipPeriod == "1 Month")
            {
                membershipFee = (membershipType == "Individual") ? 2000 : 2500;
            }

            double coachingFee = coachingHours * 1000;
            double matchFee = numMatches * 1500;
            double totalCost = membershipFee + coachingFee + matchFee;

            string result = $"Member Name: {memberName}\n" +
                            "-------------------------------------\n" +
                            $"Membership Plan: {membershipPeriod} - {membershipType}\n" +
                            $"Membership Fee: LKR {membershipFee.ToString("N2", CultureInfo.InvariantCulture)}\n" +
                            $"Coaching Hours: {coachingHours} hour(s) at LKR 1000.00 per hour = LKR {coachingFee.ToString("N2", CultureInfo.InvariantCulture)}\n" +
                            $"Matches Played: {numMatches} match(es) at LKR 1500.00 per match = LKR {matchFee.ToString("N2", CultureInfo.InvariantCulture)}\n" +
                            "-------------------------------------\n" +
                            $"Total Cost: LKR {totalCost.ToString("N2", CultureInfo.InvariantCulture)}";

            outputRichTextBox.Text = result;
        }
    }
}
