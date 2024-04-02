using BankingApp.Enums;
using BankingApp.Models;
using BankingApp.Utilities;
using BankingApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace BankingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        private List<TabItemTemplate> _tabItems;

        public event PropertyChangedEventHandler PropertyChanged;
        private TabItemTemplate _SelectedTab;
        public TabItemTemplate SelectedTab { get=>_SelectedTab; set { _SelectedTab = value;OnPropertyChanged(nameof(SelectedTab));} }
        private string _SelectedBank;
        public string SelectedBank {  get=>_SelectedBank; set { _SelectedBank = value;OnPropertyChanged(nameof(SelectedBank)); } }
        public MainWindow()
        {
            InitializeComponent();
            MainGrid.DataContext = this;
            var banks = GetBanksName();
            SelectedBank = SelectedBank ?? banks.FirstOrDefault();
            InitializeTabControls();
            SelectedTab = SelectedTab ?? _tabItems.FirstOrDefault();
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private List<string>GetBanksName()
        {
            var names = new List<string>();
            var EnumsValues = Enum.GetValues(typeof(BankType)).Cast<BankType>();
            foreach (var enumValue in EnumsValues)
                names.Add(BankUtility.GetEnumDescription(enumValue));
            return names;
        }

        private void InitializeTabControls()
        {
            try
            {
                _tabItems = new List<TabItemTemplate>
                {
                    new TabItemTemplate
                    {
                        BankName=BankUtility.GetEnumDescription(BankType.SBI),
                        TabContent = new Lazy<UserControl>(SBIBankUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        BankName=BankUtility.GetEnumDescription(BankType.Baroda),
                        TabContent = new Lazy<UserControl>(BarodaBankUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        BankName = BankUtility.GetEnumDescription(BankType.HDFC),
                        TabContent = new Lazy<UserControl>(HDFCBankUserControl.GetSingletonInstance)
                    }
                };
            }
            catch
            {

            }
        }
    }
}
