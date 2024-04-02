using System.ComponentModel;

namespace BankingApp.Enums
{
    public enum BankType
    {
        [Description("SBI Bank")]
        SBI=1,
        [Description("Baroda Bank")]
        Baroda=2,
        [Description("HDFC")]
        HDFC=3
    }
}
