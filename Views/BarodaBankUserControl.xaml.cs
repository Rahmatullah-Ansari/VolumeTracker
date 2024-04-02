using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BankingApp.Views
{
    /// <summary>
    /// Interaction logic for BarodaBankUserControl.xaml
    /// </summary>
    public partial class BarodaBankUserControl : UserControl
    {
        public static BarodaBankUserControl Instance;
        public BarodaBankUserControl()
        {
            InitializeComponent();
        }
        public static BarodaBankUserControl GetSingletonInstance()=>Instance??(Instance as BarodaBankUserControl);
    }
}
