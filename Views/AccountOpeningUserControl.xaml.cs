using System.Windows;

namespace BankingApp.Views
{
    /// <summary>
    /// Interaction logic for AccountOpeningUserControl.xaml
    /// </summary>
    public partial class AccountOpeningUserControl
    {
        private static AccountOpeningUserControl Instance;
        public AccountOpeningUserControl()
        {
            InitializeComponent();
        }
        public static AccountOpeningUserControl GetSingletonInstance() => Instance ?? (Instance = new AccountOpeningUserControl());

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(firstName.Text) || string.IsNullOrEmpty(middleName.Text) || string.IsNullOrEmpty(lastName.Text) ||
                string.IsNullOrEmpty(fathersName.Text) || string.IsNullOrEmpty(mothersName.Text) || string.IsNullOrEmpty(phoneNumber.Text) ||
                string.IsNullOrEmpty(mobileNumber.Text) || string.IsNullOrEmpty(parmanentAddress.Text) || string.IsNullOrEmpty(accountNumber.Text)))
                MessageBox.Show("Account Created Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
            else
                MessageBox.Show("All fields are mandatory", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
