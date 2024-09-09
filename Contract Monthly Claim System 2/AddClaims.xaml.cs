using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Contract_Monthly_Claim_System_2
{
    public partial class AddClaims : Window
    {
        // List to store claims
        private List<Claim> monthlyClaims;

        public AddClaims()
        {
            InitializeComponent();
            monthlyClaims = new List<Claim>();
            ClaimsDataGrid.ItemsSource = monthlyClaims;  // Bind the data grid to the monthlyClaims list
        }

        // Add Claim button click event
        private void AddClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the values from input fields
            DateTime dateOfWork = WorkDatePicker.SelectedDate ?? DateTime.Now; // Default to today if no date selected
            if (double.TryParse(HoursWorkedTextBox.Text, out double hoursWorked) && double.TryParse(HourlyRateTextBox.Text, out double hourlyRate))
            {
                // Calculate the total amount
                double totalAmount = hoursWorked * hourlyRate;

                // Create a new claim and add it to the list
                Claim newClaim = new Claim
                {
                    DateOfWork = dateOfWork.ToShortDateString(),
                    HoursWorked = hoursWorked,
                    HourlyRate = hourlyRate,
                    TotalAmount = totalAmount
                };

                monthlyClaims.Add(newClaim);
                ClaimsDataGrid.Items.Refresh();  // Refresh the data grid to show the new claim

                // Clear input fields for next entry
                HoursWorkedTextBox.Clear();
                HourlyRateTextBox.Clear();
                WorkDatePicker.SelectedDate = null;
            }
            else
            {
                MessageBox.Show("Please enter valid values for Hours Worked and Hourly Rate.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Submit button click event
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement the submission logic here (e.g., save to database or file)
            MessageBox.Show("Claims submitted successfully!", "Submission", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Back button click event
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Close this window and go back to the main window or previous window
            this.Close();
        }

        // Next button click event
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement the logic for the Next button here
            MessageBox.Show("Proceeding to the next step...", "Next", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    // Class to represent a claim
    internal class Claim
    {
        public string DateOfWork { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public double TotalAmount { get; set; }
    }
}
