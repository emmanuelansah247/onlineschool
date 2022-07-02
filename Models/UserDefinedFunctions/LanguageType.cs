

using System.Collections.Generic;

namespace bim_edu.Models
{
    public static class LanguageType
    {
        public static string French = "fr";
        public static string English = "en";
        public static List<string> GetAll()
        {
           List<string> new_list = new List<string>();
           new_list.Add(French);
           new_list.Add(English);

           return new_list;

        }

    }
}