
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bim_edu.Models
{
    public class ProgramDocument
    {
        [Key]
        public int ProgramDocumentId { get; set; }
        public string Description {get;set;}
        public string FilePath {get;set;}
        [ForeignKey("Programme")]
        public int ProgrammeId {get;set;}

        public bool isremoved {get;set;}
    }
}