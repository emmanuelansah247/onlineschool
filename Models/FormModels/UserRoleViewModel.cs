

using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class UserRoleViewModel
    {
        [Required]
        public string UserId {get;set;}
        [Required]
        public string RoleId {get;set;}
        
    }
}
