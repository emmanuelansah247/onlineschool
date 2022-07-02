using bim_edu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bim_edu.DataContect.Controllers
{
    public class BimEduDataContext : IdentityDbContext<ApplicationUser>
    {
        public BimEduDataContext(DbContextOptions<BimEduDataContext> options) : base(options)
        {
           
        }

        public DbSet<Programme> Programmes {get;set;}
        public DbSet<ProgramCalender> ProgramCalenders {get;set;}
        public DbSet<PaymentByPassCode> PaymentByPassCodes {get;set;}
        public DbSet<Lecturer> Lecturers {get;set;}
        public DbSet<Course> Courses {get;set;}
        public DbSet<CourseLecturer> CourseLecturers {get;set;}
        public DbSet<ApplicationUser> AspNetUsers {get;set;}
        public DbSet<ApplicationUserLogin> ApplicationUserLogins {get;set;}
        public DbSet<Certification> Certifications {get;set;}
        public DbSet<Comment> Comments {get;set;}
        public DbSet<CommentReply> CommentReplies {get;set;}
        public DbSet<ApplicationError> applicationerrors {get;set;}
        public DbSet<Payment> Payments {get;set;}
        public DbSet<ProgrammeApplication> ProgrammeApplications {get;set;}
        public DbSet<Video> Videos {get;set;}
        public DbSet<UploadedDocument> UploadedDocuments {get;set;}
        public DbSet<StudentFeeToPay> StudentFeesToPay {get;set;}
        public DbSet<ProgramDocument> ProgramDocuments {get;set;}
        public DbSet<ShareFile> ShareFiles {get;set;}
        public DbSet<Question> Questions {get;set;}
        public DbSet<QuestionStudentProvidedSolution> QuestionStudentProvidedSolutions {get;set;}
        public DbSet<QuestionLecturerEvaluateStudentSolution> QuestionLecturerEvaluateStudentSolutions {get;set;}

    }

}