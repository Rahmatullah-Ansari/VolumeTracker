﻿using System.Windows;

namespace BankingApp.Views
{
    /// <summary>
    /// Interaction logic for KYCUserControl.xaml
    /// </summary>
    public partial class KYCUserControl
    {
        private static KYCUserControl Instance;
        public KYCUserControl()
        {
            InitializeComponent();
        }
        public static KYCUserControl GetSingletonInstance() => Instance ?? (Instance = new KYCUserControl());
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (!(string.IsNullOrEmpty(firstname.Text) || string.IsNullOrEmpty(lastname.Text) || string.IsNullOrEmpty(middlename.Text) ||
                string.IsNullOrEmpty(gender.Text) || string.IsNullOrEmpty(mobileno.Text) || string.IsNullOrEmpty(accountnumber.Text) ||
                string.IsNullOrEmpty(address.Text) || string.IsNullOrEmpty(fathername.Text)))
            {
                MessageBox.Show("Account Re-KYC Successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                firstname.Text = lastname.Text = middlename.Text = gender.Text = mobileno.Text = accountnumber.Text = address.Text = fathername.Text = mothername.Text = "";
            }
            else
                MessageBox.Show("All fields are mandatory", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
