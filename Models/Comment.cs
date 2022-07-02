using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bim_edu.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public ApplicationUser ApplicationUser {get;set;}
        public int ProgrammeId {get;set;}
        public Programme Programme {get;set;}
        public int CourseLecturerId {get;set;}
        public CourseLecturer CourseLecturer {get;set;}
        public IEnumerable<CommentReply> CommentReplies {get;set;}
        public string message {get;set;}
        public DateTime date {get;set;}

        public bool isremoved {get;set;}
    }
}