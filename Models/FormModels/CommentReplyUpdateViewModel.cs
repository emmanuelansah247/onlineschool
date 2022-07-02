using System;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class CommentReplyUpdateViewModel
    {
        public int CommentReplyId { get; set; }
        public string updated_reply_message {get;set;}
    }
}