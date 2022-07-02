using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class CommentUpdateViewModel
    {
        public int CommentId { get; set; }
        public string updated_message {get;set;}
    }
}