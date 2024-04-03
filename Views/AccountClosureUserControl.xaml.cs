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
                string.IsNullOrEmpty(permanentaddress.Text) || string.IsNullOrEmpty(mothersname.Text) || string.IsNullOrEmpty(phonenumber.Text)))
            {
                MessageBox.Show("Account Closed Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                firstname.Text = lastname.Text = middlename.Text = fathersname.Text = mobilenumber.Text = aadharcardnummber.Text = phonenumber.Text = permanentaddress.Text = mothersname.Text = "";
            }
            else
                MessageBox.Show("All fields are mandatory", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}

