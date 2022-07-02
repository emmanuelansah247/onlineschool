using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using bim_edu.DataContect.Controllers;
using bim_edu.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bim_edu.UserDefined.Functions;

namespace bim_edu.APIs.Controllers
{
    public class ApiOtherController : Controller
    {

        string currentApplicationForErrorLogging = "ApiOtherController";
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        BimEduDataContext _dataContext;
        ApiErrorController _apierrorcontroller;
        private IHostingEnvironment _hostingEnvironment;
        private string _BaseUrl;
        private string _BimEduEmailReceiverent;
        private IConfiguration _conf;
        public ApiOtherController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,
                                 BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._apierrorcontroller = new ApiErrorController(datacontenxt,conf,environment);
            this._userManager = userManager;
            this._signInManager = signInManager;
            this._dataContext = datacontenxt;
            this._conf = conf;
            this._hostingEnvironment = environment;
            this._BaseUrl = _conf.GetValue<string>("Bim-Edu:BaseUrl");
            this._BimEduEmailReceiverent = _conf.GetValue<string>("Email:enquiryemailreceiver");
        } 
        
        [HttpGet]
        public async Task<IEnumerable<Comment>> CommentsGetAll(int ProgramId,int CourseLecturerId)
        {

            var awaited_result =  await this._dataContext.Comments
                                            .Where(p=>p.isremoved == false && 
                                            p.Programme.ProgrammeId == ProgramId && 
                                            p.CourseLecturerId == CourseLecturerId)
                                            .Include("ApplicationUser")
                                            .Include("CommentReplies.ApplicationUser")
                                            .ToListAsync();
            IEnumerable<Comment> result =   awaited_result.ToList();
            return result;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Comment>> CommentsGetAllUrlRequest(int ProgramId,int CourseLecturerId)
        {

            var awaited_result =  await this._dataContext.Comments
                                            .Where(p=>p.isremoved == false && 
                                            p.Programme.ProgrammeId == ProgramId && p.CourseLecturerId == CourseLecturerId)
                                            .Include("ApplicationUser")
                                            .ToListAsync();
            IEnumerable<Comment> result =   awaited_result.ToList();
            return result;
        }
        
        [HttpPost]
        public async Task<bool> AddComment(Comment model,string lang = "fr")
        {
            try{

                var user = await _userManager.FindByIdAsync(model.ApplicationUser.Id);
                this._dataContext.Comments.Add(model);
                await this._dataContext.SaveChangesAsync();
                var result = await this.GetConcernProgramUsers(model.ProgrammeId);
                Comment comment_details = await this._dataContext.Comments.Where(predicate=>predicate.CommentId == model.CommentId)
                                    .Include("Programme")
                                    .Include("CourseLecturer.Course")
                                    .FirstOrDefaultAsync();

                string subject = "NEW COMMENT";
                string message = "<div style='padding:20px;background:#4b345d;color:white;text-align:center;'>" +
                "<h1 style='color:white;font-weight:bolder;'>" +
                "<span style='color:white'>" +  
                "New comment by " + user.FirstName.ToUpper() + " " + user.LastName.ToUpper() + " ( " + 
                comment_details.Programme.Name + " - " + comment_details.CourseLecturer.Course.Name +  
                " )" + " added to Bim-Edu Online Forum" +
                "</span>" +
                "</h1></br></br>" +
                "<a style='color:white;background-color:#e90172;padding:5px;text-decoration:none;' href='"+ _BaseUrl + "Student/Welcome'> CLICK HERE TO GO TO DASHBOARD </a><br/><br/>"+
                "</div>";
                
                List<ApplicationUser> concern_program_users = result.ToList();
                foreach(ApplicationUser item in concern_program_users){
                    if(item.Id != user.Id){

                        await userEmailSender.EmailSender(_conf,item.Email,subject,message);

                    }
                }
                
                List<CourseLecturer> mail_courseLecturers = await this._dataContext.CourseLecturers
                                                            .Where(predicate=>predicate.CourseLecturerId == model.CourseLecturerId)
                                                            .Include("Lecturer.ApplicationUser")
                                                            .ToListAsync();
                                                                                              
                foreach(CourseLecturer item in mail_courseLecturers){
                    if(item.Lecturer.ApplicationUser.Id != user.Id){

                        await userEmailSender.EmailSender(_conf,item.Lecturer.ApplicationUser.Email,subject,message);

                    }
                }
                
                await userEmailSender.EmailSender(_conf,this._BimEduEmailReceiverent,subject,message);

                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }
        
        [HttpPost]
        public async Task<bool> CommentUpdate(CommentUpdateViewModel model)
        {
            try{
                var old_comment = await this._dataContext.Comments.Where(predicate=>predicate.CommentId == model.CommentId).FirstOrDefaultAsync();
                old_comment.message = model.updated_message;
                await this._dataContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }
        
        [HttpPost]
        public async Task<bool> CommentDelete(CommentUpdateViewModel model)
        {
            try{
                var old_comment = await this._dataContext.Comments.Where(predicate=>predicate.CommentId == model.CommentId).FirstOrDefaultAsync();
                old_comment.isremoved = true;
                await this._dataContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }
        
        [HttpPost]
        public async Task<bool> CommentReply(CommentReplyViewModel model)
        {
            try{
                ApplicationUser user = await _userManager.FindByIdAsync(model.ApplicationUserId);
                CommentReply new_comment_reply = new CommentReply(){
                    ApplicationUser = user,
                    CommentId = model.CommentId,
                    message = model.message,
                    date  = DateTime.Now
                };
                await this._dataContext.CommentReplies.AddAsync(new_comment_reply);
                await this._dataContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }
        
        [HttpPost]
        public async Task<bool> CommentReplyUpdate(CommentReplyUpdateViewModel model)
        {
            try{
                CommentReply old_comment_reply = await this._dataContext.CommentReplies.Where(predicate=>predicate.CommentReplyId == model.CommentReplyId).FirstOrDefaultAsync();
                old_comment_reply.message = model.updated_reply_message;
                await this._dataContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }
        
        [HttpPost]
        public async Task<bool> CommentReplyDelete(int CommentReplyDeleteId)
        {
            try{
                CommentReply old_comment_reply = await this._dataContext.CommentReplies.Where(predicate=>predicate.CommentReplyId == CommentReplyDeleteId).FirstOrDefaultAsync();
                old_comment_reply.isremoved = true;
                await this._dataContext.SaveChangesAsync();
                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
            }
        }

        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> GetConcernProgramUsers(int programId)
        {
            List<ApplicationUser> concern_program_users =  await this._dataContext.AspNetUsers
                                                                .Where(p=> p.ProgrammeApplications.Any(pre=> 
                                                                        pre.Programme.ProgrammeId == programId &&
                                                                        pre.isApproved == true && 
                                                                        pre.isremoved == false) == true)
                                                                .ToListAsync();

            return concern_program_users;
        }

        [HttpGet]
        public IEnumerable<Video> GetAllVideos()
        {
            IEnumerable<Video> result = this._dataContext.Videos.Where(p=>p.isremoved == false).ToList();
            return result;
        }

        [HttpGet]
        public IEnumerable<Video> GetAllVideosOfAProgramme(int ProgrammeId)
        {
            IEnumerable<Video> result = this._dataContext.Videos
                                        .Where(p=>p.isremoved == false && p.Programme.ProgrammeId == ProgrammeId)
                                        .ToList();
            return result;
        }
        
        [HttpPost]
        public async Task<string> AddVideo(Video model)
        {
            try{
               var programme = await this._dataContext.Programmes.Where(p=>p.ProgrammeId == model.Programme.ProgrammeId).FirstOrDefaultAsync();
               model.Programme = programme;
               await this._dataContext.Videos.AddAsync(model);
               await this._dataContext.SaveChangesAsync();
                return GeneralStoredNames.Success;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                 return GeneralStoredNames.Error;
            }
        }
        
        [HttpPost]
        public async Task<string> UpdateVideo(Video model)
        {
            try{
                var result = await this._dataContext.Videos.Where(p=>p.VideoId == model.VideoId).FirstOrDefaultAsync();
                if(result != null){
                        result.Url = model.Url;
                        result.Title = model.Title;
                        await this._dataContext.SaveChangesAsync();
                        return GeneralStoredNames.Success;
                }
                }
                catch(Exception ex){
                    _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                }
                
            return GeneralStoredNames.Error;
        }
        
        [HttpPost]
        public async Task<string> DeleteVideo(int VideoId)
        {
                try{
                var result = await this._dataContext.Videos.Where(p=>p.VideoId == VideoId).FirstOrDefaultAsync();
                if(result != null){
                        result.isremoved = true;
                        await this._dataContext.SaveChangesAsync();
                        return GeneralStoredNames.Success;
                }
                }
                catch(Exception ex){
                    _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                }

            return GeneralStoredNames.Error;
        }
        


    }
}
