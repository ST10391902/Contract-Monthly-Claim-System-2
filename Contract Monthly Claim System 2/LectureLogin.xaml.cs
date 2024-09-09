using System.Windows;

namespace Contract_Monthly_Claim_System_2
{
    public partial class LectureLogin : Window
    {
        public LectureLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // For now, we assume the login is always successful
            LectureDetails lectureDetails = new LectureDetails();
            lectureDetails.Show();
            this.Close(); // Close the login window
        }
    }
}
