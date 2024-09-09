using System.Windows;

namespace Contract_Monthly_Claim_System_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetStartedButton_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to LectureLogin window
            LectureLogin lectureLogin = new LectureLogin();
            lectureLogin.Show();
            this.Close(); // Close the MainWindow
        }
    }
}
