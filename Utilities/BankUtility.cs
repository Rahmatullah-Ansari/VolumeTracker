using BankingApp.Enums;
using EnumsNET;

namespace BankingApp.Utilities
{
    public class BankUtility
    {
        public static string GetEnumDescription(BankType enumValue)
        {
            return enumValue.AsString(EnumFormat.Description);
        }
        public static BankType GetEnumFromDescription(string description)
        {
            switch (description)
            {
                case "SBI Bank":
                    return BankType.SBI;
                case "Bank of Baroda":
                    return BankType.Baroda;
                default:
                    return BankType.HDFC;
            }
        }
    }
}
