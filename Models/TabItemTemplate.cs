using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BankingApp.Models
{
    public class TabItemTemplate
    {
        public TabItemTitle TabTitle { get; set; }
        public string BankName { get; set; }
        public Lazy<UserControl> TabContent { get; set; }
    }
}
