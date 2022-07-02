using System;
using System.Collections.Generic;
using System.Globalization;

namespace bim_edu.Models
{

    public static class EducationLevels
    {
        public static List<string> Levels(){
            List<string> levels = new List<string>();
            levels.Add("High School");
            levels.Add("Licence");
            levels.Add("Masters");
            levels.Add("Phd");
            levels.Add("Docturate");
            return levels;
        }
        public static List<string> en_Levels(){
            List<string> levels = new List<string>();
            levels.Add("High School");
            levels.Add("Degree");
            levels.Add("Masters");
            levels.Add("Phd");
            levels.Add("Docturate");
            return levels;
        }
    }

}