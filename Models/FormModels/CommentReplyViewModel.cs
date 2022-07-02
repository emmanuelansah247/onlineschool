using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class CommentReplyViewModel
    {
        public int CommentId { get; set; }
        public string message {get;set;}
        public string ApplicationUserId {get;set;}
    }
}