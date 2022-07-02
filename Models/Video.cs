using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class Video
    {
        [Key]
        public int VideoId { get; set; }
        public string Url {get;set;}
        public string Title {get;set;}
        public Programme Programme {get;set;}
        public bool isremoved {get;set;}
    }
}