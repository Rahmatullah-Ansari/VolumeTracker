using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
namespace BankingApp.Views
{
    /// <summary>
    /// Interaction logic for SBIBankUserControl.xaml
    /// </summary>
    public partial class SBIBankUserControl
    {
        private static SBIBankUserControl Instance;
        public List<TabItemTemplate> _tabItems;
        public TabItemTemplate SelectedTab { get; set; }
        public SBIBankUserControl()
        {
            InitializeComponent();
            MainGrid.DataContext = this;
            InitializeTabControls();
            MainWindowTabs.ItemsSource = _tabItems;
            SelectedTab = SelectedTab ?? _tabItems.FirstOrDefault();
            MainWindowTabs.SelectionChanged += OnTabSelected;
        }

        private void OnTabSelected(object sender, SelectionChangedEventArgs e)
        {
        }

        private void InitializeTabControls()
        {
            _tabItems = new List<TabItemTemplate>
                {
                    new TabItemTemplate
                    {
                        TabTitle =new TabItemTitle{Title = Properties.Resources.LangKeyHome,ImageUrl="/BankingApp;component/Images/HomeIcon.png"},
                        TabContent = new Lazy<UserControl>(HomeUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        TabTitle =new TabItemTitle{Title = Properties.Resources.LangKeyAccountOpening,ImageUrl="/BankingApp;component/Images/AccountOpening.png"},
                        TabContent = new Lazy<UserControl>(AccountOpeningUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        TabTitle =new TabItemTitle{Title = Properties.Resources.LangKeyAccountClosure,ImageUrl="/BankingApp;component/Images/AccountClosure.png"},
                        TabContent = new Lazy<UserControl>(AccountClosureUserControl.GetSingletonInstance)
                    },
                    new TabItemTemplate
                    {
                        TabTitle =new TabItemTitle{Title = Properties.Resources.LangKeyReKycOfCustomer,ImageUrl="/BankingApp;component/Images/KYC.png"},
                        TabContent = new Lazy<UserControl>(KYCUserControl.GetSingletonInstance)
                    }
                };
        }

        public static SBIBankUserControl GetSingletonInstance()=>Instance ?? (Instance = new SBIBankUserControl());
    }
}
