using System;
using System.Collections.Generic;
using System.Globalization;

namespace bim_edu.Models
{

    public static class CountryList
    {
        public static List<string> Countries(){
            List<string> CultureList = new List<string>();
            CultureInfo[] getcultureinfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach(CultureInfo getculture in getcultureinfo){
                string country_name = getculture.EnglishName.Split('(')[1].Split(')')[0].Trim();
                if(!(CultureList.Contains(country_name))){
                    CultureList.Add(country_name);
                }
            }
            CultureList.Sort();
            return CultureList;
        }
    }

}