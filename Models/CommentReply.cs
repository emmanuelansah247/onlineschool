using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class CommentReply
    {
        [Key]
        public int CommentReplyId { get; set; }
        public ApplicationUser ApplicationUser {get;set;}
        public int CommentId {get;set;}
        public Comment Comment {get;set;}
        public string message {get;set;}
        public DateTime date {get;set;}

        public bool isremoved {get;set;}
    }
}