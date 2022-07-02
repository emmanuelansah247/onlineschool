
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class ShareFile
    {
        [Key]
        public int ShareFileId { get; set; }
        public string Description {get;set;}
        public string FilePath {get;set;}
        
        [ForeignKey("CourseLecturer")]
        public int CourseLecturerId {get;set;}

        public bool isremoved {get;set;}
    }
}