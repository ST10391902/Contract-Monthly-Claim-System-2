using System;
using System.Collections.Generic;
using System.Windows;

namespace Contract_Monthly_Claim_System_2
{
    public partial class StatusOrViewClaims : Window
    {
        // List to store monthly claims
        private List<MonthlyClaim> monthlyClaims;

        public StatusOrViewClaims()
        {
            InitializeComponent();
            // Initialize monthly claims (sample data for testing purposes)
            monthlyClaims = new List<MonthlyClaim>
            {
                new MonthlyClaim { ClaimId = 1, LecturerName = "John Doe", DateOfWork = "01/09/2024", HoursWorked = 5, HourlyRate = 50, TotalAmount = 250, Status = "Pending" },
                new MonthlyClaim { ClaimId = 2, LecturerName = "Jane Smith", DateOfWork = "02/09/2024", HoursWorked = 8, HourlyRate = 60, TotalAmount = 480, Status = "Pending" }
            };

            ClaimsDataGrid.ItemsSource = monthlyClaims;  // This binds the data to the DataGrid
        }

        // Approve button click event
        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected monthly claim and approve it
            MonthlyClaim selectedClaim = ClaimsDataGrid.SelectedItem as MonthlyClaim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Approved";
                ClaimsDataGrid.Items.Refresh();  // Refresh the DataGrid to show updated status
            }
            else
            {
                MessageBox.Show("Please select a claim to approve.");
            }
        }

        // Reject button click event
        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected monthly claim and reject it
            MonthlyClaim selectedClaim = ClaimsDataGrid.SelectedItem as MonthlyClaim;
            if (selectedClaim != null)
            {
                selectedClaim.Status = "Rejected";
                ClaimsDataGrid.Items.Refresh();  // Refresh the DataGrid to show updated status
            }
            else
            {
                MessageBox.Show("Please select a claim to reject.");
            }
        }

        // Submit button click event
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Submit the changes (this is where you would save the changes to a database or file)
            MessageBox.Show("Changes submitted successfully.");
        }

        // Back button click event
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Close this window and return to the previous one
            this.Close();
        }
    }

    // Class to represent a monthly claim
    public class MonthlyClaim
    {
        public int ClaimId { get; set; }
        public string LecturerName { get; set; }
        public string DateOfWork { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public double TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
