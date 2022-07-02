
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace bim_edu.Models
{
    public class Programme
    {
        [Key]
        [Display(Name="Program")]
        public int ProgrammeId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name {get;set;}
        [Required(ErrorMessage = "Description is required")]
        public string Description {get;set;}
        public string Url {get;set;}
        [Required]
        [DataType(DataType.Currency)]
        public double ApplicationFee {get;set;}
        [Required]
        [DataType(DataType.Currency)]
        public double Fee {get;set;}
        public int CertificationId {get;set;}
        public Certification Certification {get;set;}
        public int ProgramCalenderId {get;set;}
        public virtual ProgramCalender ProgramCalender {get;set;}
        public int LecturerId {get;set;}
        public IEnumerable<ProgramDocument> ProgramDocuments {get;set;}
        public IEnumerable<CourseLecturer> CourseLecturers {get;set;}

        public IEnumerable<Question> Questions {get;set;}
        public string Language {get;set;}

        public bool isremoved {get;set;}
    }
}