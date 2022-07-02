

using System.Collections.Generic;

namespace bim_edu.Models
{
    public static class PaymentType
    {
        public static string Paid = "Paid";
        public static string Free = "Fees";
        public static string Waived = "Waived";
        public static List<string> GetAllTypes()
        {
           List<string> new_list = new List<string>();
           new_list.Add(Paid);
           new_list.Add(Free);
           new_list.Add(Waived);

           return new_list;

        }

    }
}