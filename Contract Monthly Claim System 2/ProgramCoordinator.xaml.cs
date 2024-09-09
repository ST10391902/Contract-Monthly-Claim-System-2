using System.Windows;

namespace Contract_Monthly_Claim_System_2
{
    public partial class ProgramCoordinator : Window
    {
        public ProgramCoordinator()
        {
            InitializeComponent();
        }

        // Login button click event
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            // Check if the email and password are correct (this is a placeholder for actual authentication logic)
            if (email == "coordinator@domain.com" && password == "password123")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                // Open the next window (e.g., the claims management window) after login
                StatusOrViewClaims statusOrViewClaims = new StatusOrViewClaims();
                statusOrViewClaims.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
