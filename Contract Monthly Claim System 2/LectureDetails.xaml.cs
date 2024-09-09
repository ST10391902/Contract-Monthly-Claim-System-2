using System;
using System.Windows;

namespace Contract_Monthly_Claim_System_2
{
    public partial class LectureDetails : Window
    {
        public LectureDetails()
        {
            InitializeComponent();
        }

        // Back Button click event handler
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the Lecture Details window and go back to the previous window
            this.Close();
        }

        // Next Button click event handler
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            // Perform actions such as data validation or saving entered details
            // Navigate to the next form (e.g., AddClaims window)
            AddClaims addClaimsWindow = new AddClaims();
            addClaimsWindow.Show();
            this.Close(); // Optionally close the current window if not needed after navigation
        }
    }
}
