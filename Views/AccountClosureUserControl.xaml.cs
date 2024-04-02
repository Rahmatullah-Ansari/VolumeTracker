using System.Windows;

namespace BankingApp.Views
{
    /// <summary>
    /// Interaction logic for AccountClosureUserControl.xaml
    /// </summary>
    public partial class AccountClosureUserControl
    {
        private static AccountClosureUserControl Instance;
        public AccountClosureUserControl()
        {
            InitializeComponent();
        }
        public static AccountClosureUserControl GetSingletonInstance() => Instance ?? (Instance = new AccountClosureUserControl());
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(middlename.Text) ||
                string.IsNullOrEmpty(fathersname.Text) || string.IsNullOrEmpty(mobilenumber.Text) || string.IsNullOrEmpty(aadharcardnummber.Text) ||
                string.IsNullOrEmpty(permanentaddress.Text) || string.IsNullOrEmpty(mothersname.Text)))
                MessageBox.Show("Account Created Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            else
                MessageBox.Show("All fields are mandatory", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

