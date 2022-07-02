
using System.Collections.Generic;

namespace bim_edu.Models
{
    public static class RoleName
    {
        public static string Admin = "Admin";
        public static string Staff = "Staff";

        public static List<string> GetRoles(){
            List<string> roles = new List<string>();
            roles.Add(Admin);
            roles.Add(Staff);
            return roles;
        }

    }
}