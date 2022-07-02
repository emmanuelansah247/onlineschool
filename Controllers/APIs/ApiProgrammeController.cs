using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using bim_edu.DataContect.Controllers;
using bim_edu.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using bim_edu.UserDefined.Functions;

namespace bim_edu.APIs.Controllers
{
    public class ApiProgrammeController : Controller
    {

        string currentApplicationForErrorLogging = "ApiProgrammeController";
        BimEduDataContext _datacontext;
        ApiErrorController _apierrorcontroller;
        private IHostingEnvironment _environment;
        private string _BaseUrl;
        private IConfiguration _conf;
        public ApiProgrammeController(BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._apierrorcontroller = new ApiErrorController(datacontenxt,conf,environment);
            this._datacontext = datacontenxt;
            this._conf = conf;
            this._environment = environment;
            this._BaseUrl = _conf.GetValue<string>("Bim-Edu:BaseUrl");
        } 
        
        [HttpGet]
        public IEnumerable<Programme> GetAllPorgrammes()
        {
            IEnumerable<Programme> result =   this._datacontext.Programmes
                                              .Where(p=>p.isremoved == false)
                                              .Include("ProgramCalender")
                                              .Include("Certification")
                                              .Include("Questions")
                                              .Include("CourseLecturers.Lecturer.ApplicationUser")
                                              .Include("CourseLecturers.Course")
                                              .ToList();
            return result;
        }
        
        [HttpPost]
        public async Task<bool> ProgrammeApplicationRemove(int ProgrammeApplicationId)
        {
            try{
              ProgrammeApplication result = await this._datacontext.ProgrammeApplications
                                                    .Where( p=>p.ProgrammeApplicationId == ProgrammeApplicationId)
                                                    .FirstOrDefaultAsync();
              result.isremoved = true;
              await this._datacontext.SaveChangesAsync();
              
              return true;
            }
            catch(Exception  ex){
                  _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                  return false;
            }
        }
        
        [HttpPost]
        public async Task<bool> ProgrammeApplicationUpdateWithNewProgram(int ProgrammeApplicationId,int ProgramId)
        {
            try{
              ProgrammeApplication result = await this._datacontext.ProgrammeApplications
                                                    .Where( p=>p.ProgrammeApplicationId == ProgrammeApplicationId)
                                                    .FirstOrDefaultAsync();

              Programme program_result = await this._datacontext.Programmes
                                                    .Where( p=>p.ProgrammeId == ProgramId)
                                                    .FirstOrDefaultAsync();
              result.Programme = program_result;
              await this._datacontext.SaveChangesAsync();
              return true;
            }
            catch(Exception  ex){
                  _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                  return false;
            }
        }
        
        [HttpGet]
        public IEnumerable<Programme> ProgrammeStaff(string Id)
        {
            IEnumerable<Programme> result =   this._datacontext.Programmes
                                              .Where(predicate=>predicate.CourseLecturers.Any(pred=>pred.Lecturer.ApplicationUserId == Id))
                                              .Where(p=>p.isremoved == false)
                                              .Include("ProgramCalender")
                                              .Include("Certification")
                                              .Include("Questions")
                                              .Include("CourseLecturers.Lecturer.ApplicationUser")
                                              .Include("CourseLecturers.Course")
                                              .ToList();
            return result;
        }
        [HttpGet]
        public async Task<IEnumerable<Programme>> PorgrammesSearch(string term)
        {
            var awaited_result = await  this._datacontext.Programmes
                                              .Where(p=>p.isremoved == false && p.Description.Contains(term))
                                              .ToListAsync();
            IEnumerable<Programme> result = awaited_result.ToList();
            return result;
        }

        [HttpGet]
        public async Task<Programme> PorgrammeGetById(int ProgramId)
        {
            Programme result = await this._datacontext.Programmes
                                              .Where(p=>p.isremoved == false && p.ProgrammeId == ProgramId)
                                              .Include("ProgramCalender")
                                              .Include("Certification")
                                              .Include("CourseLecturers.Lecturer.ApplicationUser")
                                              .Include("CourseLecturers.Course")
                                              .Include("Questions.QuestionStudentProvidedSolutions.QuestionLecturerEvaluateStudentSolutions")
                                              .Include("Questions.QuestionStudentProvidedSolutions.ApplicationUser")
                                              .FirstOrDefaultAsync();
            return result;
        }

        [HttpGet]
        public async Task<IEnumerable<ShareFile>> ShareFileGetById(int CourseLectureId)
        {
            List<ShareFile> result = await this._datacontext.ShareFiles
                                              .Where(p=>p.isremoved == false && p.CourseLecturerId == CourseLectureId)
                                              .ToListAsync();
            return result;
        }

        [HttpPost]
        public async Task<bool> ShareFileAdd(ShareFileViewModel model)
        {
          try{
              var filepath = await this.SaveFile(model.IFormFile,GeneralStoredNames.Share_File_Directory);
              if(filepath != null){
                  ShareFile entity = new ShareFile(){
                  Description = model.Description,
                  FilePath = filepath,
                  CourseLecturerId = model.CourseLecturerId
                  };
                 await this._datacontext.ShareFiles.AddAsync(entity);
                 await this._datacontext.SaveChangesAsync();
                 return true;
              }
              else{
                return false;
              }
              
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
          }
        }

        [HttpGet]
        public async Task<bool> ShareFileDeleteById(int ShareFileId)
        {
            try{
              ShareFile result = await this._datacontext.ShareFiles
                                                    .Where( p=>p.ShareFileId == ShareFileId)
                                                    .FirstOrDefaultAsync();
              result.isremoved = true;
              await this._datacontext.SaveChangesAsync();
              
              return true;
            }
            catch(Exception  ex){
                  _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                  return false;
            }
        }

        [HttpGet]
        public CourseLecturer CourseLectureGetById(int CourseLecturerId)
        {
            CourseLecturer courseLecturer =  this._datacontext.CourseLecturers
                                                        .Include("Lecturer.ApplicationUser")
                                                        .Include("Course")
                                                        .Where(p=>p.CourseLecturerId == CourseLecturerId)
                                                        .FirstOrDefault();
            return courseLecturer;
        }
    
        [HttpGet]
        public ProgrammeApplication GetProgramApplication(int Id)
        {
            ProgrammeApplication result =   this._datacontext.ProgrammeApplications
                                            .Where(p=>p.ProgrammeApplicationId == Id)
                                            .Include("Programme")
                                            .FirstOrDefault();
            return result;
        }
    
        [HttpGet]
        public StudentFeeToPay GetStudentFeeToPay(int Id)
        {
            StudentFeeToPay result =   this._datacontext.StudentFeesToPay.Where(p=>p.StudentFeeToPayId == Id).FirstOrDefault();
            return result;
        }
    
        [HttpGet]
        public IEnumerable<ProgrammeApplication> GetAllPorgramApplications()
        {
            IEnumerable<ProgrammeApplication> result =   this._datacontext.ProgrammeApplications.Where(p=>p.isremoved == false).ToList();
            return result;
        }
    
        [HttpGet]
        public async Task<ProgrammeApplication> ProgramApplicationsToQueryFeesForAStudent(int ProgramApplicationId)
        {
            ProgrammeApplication result =     await this._datacontext.ProgrammeApplications
                                                            .Where(predicate=>predicate.isremoved == false 
                                                            && predicate.ProgrammeApplicationId == ProgramApplicationId)
                                                            .Include("StudentFeesToPay")
                                                            .Include("StudentFeesToPay")
                                                            .FirstOrDefaultAsync();
            return result;
        }

        [HttpPost]
        public string ProgramAdd(ProgramViewModel model)
        {
          try{
              Programme entity = new Programme(){
                Name = model.Name,
                Description = model.Description ,
                ApplicationFee = model.ApplicationFee,
                Fee = model.Fee,
                CertificationId = model.CertificationId,
                Url = model.Url,
                Language= model.Language
              };
              ProgramCalender defaultcalender = this._datacontext.ProgramCalenders.FirstOrDefault();
              if(defaultcalender != null){
                  entity.ProgramCalender = defaultcalender;
              }else{
                entity.ProgramCalender = new ProgramCalender(){
                  Description = "NOT AVAILABLE",
                  PathToCalender = null

                };
              }
              this._datacontext.Add(entity);
              this._datacontext.SaveChanges();
              return GeneralStoredNames.Success;
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return GeneralStoredNames.Error;
          }
        }

        [HttpPost]
        public bool ProgramUpdate(ProgramViewModel model)
        {
          try{
            var entity = this._datacontext.Programmes
                                        .Where(p=>p.ProgrammeId == model.ProgramId)
                                        .FirstOrDefault();
                entity.Name = model.Name;
                entity.Description = model.Description ;
                entity.ApplicationFee = model.ApplicationFee;
                entity.Fee = model.Fee;
                entity.CertificationId = model.CertificationId;
                entity.Url = model.Url;
                entity.Language= model.Language;
                this._datacontext.SaveChanges();
                return true;
            }
            catch(Exception  ex){
                  _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                  return false;
            }
        }

        [HttpPost]
        public Programme Find(int Id)
        {
          try{
            var result = this._datacontext.Programmes
                                        .Where(p=>p.ProgrammeId == Id).FirstOrDefault();
            return result;
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return null;
          }
        }
    
        [HttpGet]
        public IEnumerable<ProgramDocument> GetAllFileForAProgram(int Id)
        {
            IEnumerable<ProgramDocument> result =   this._datacontext.ProgramDocuments.Where(predicate=>predicate.isremoved == false 
            && predicate.ProgrammeId == Id).ToList();
            return result;
        }

        [HttpPost]
        public async Task<string> AddFileToAProgram(ProgramDocumentViewModel model)
        {
          try{
              var filepath = await this.SaveFile(model.IFormFile,GeneralStoredNames.Program_Document_Directory);
              if(filepath != null){
                  ProgramDocument entity = new ProgramDocument(){
                  Description = model.Description,
                  FilePath = filepath,
                  ProgrammeId = model.ProgrammeId
                  };
                 await this._datacontext.ProgramDocuments.AddAsync(entity);
                 await this._datacontext.SaveChangesAsync();
                 return GeneralStoredNames.Success;
              }
              else{
                return GeneralStoredNames.Error;
              }
              
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return GeneralStoredNames.Error;
          }
        }

    
        [HttpGet]
        public async Task<string> DeleteFileForAProgram(int Id)
        {
          try{

                ProgramDocument result =  await this._datacontext.ProgramDocuments.Where(predicate=>predicate.ProgramDocumentId == Id).FirstOrDefaultAsync();
                if(result != null){
                  result.isremoved = true;
                  await this._datacontext.SaveChangesAsync();
                }
                return GeneralStoredNames.Success;
              }
              catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return GeneralStoredNames.Error;

              }
        }
    
        
        [HttpPost]
        public async Task<bool> AddProgramCalenderToProgram(ProgramCalenderViewModel model)
        {
          try{

              var filepath = await this.SaveFile(model.IFormFile,GeneralStoredNames.Program_Calender_Path);
              if(filepath != null){
                  ProgramCalender new_program_calender = new ProgramCalender(){
                    Description = model.Description,
                    PathToCalender = filepath
                  };

                  await this._datacontext.ProgramCalenders.AddAsync(new_program_calender);
                  await this._datacontext.SaveChangesAsync();

                  this._datacontext.Entry(new_program_calender).GetDatabaseValues();
                  Programme program = await this.PorgrammeGetById(model.ProgramId);
                  program.ProgramCalender = new_program_calender;
                  await this._datacontext.SaveChangesAsync();

                 return true;
              }
              else{
                return false;
              }
              
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
          }
        }

        [HttpPost]
        public async Task<bool> ApplicationApproval(int ProgrammeApplicationId,string ApplicationUserId)
        {
            try{

                ProgrammeApplication programmeApplication = await this._datacontext.ProgrammeApplications
                                                          .Where(p=> p.ProgrammeApplicationId == ProgrammeApplicationId)
                                                          .FirstOrDefaultAsync();

                ApplicationUser applicationUser = await this._datacontext.AspNetUsers
                                                  .Where(predicate=>predicate.Id == ApplicationUserId)
                                                  .FirstOrDefaultAsync();

                programmeApplication.isRejected = false;
                programmeApplication.isApproved = true;
                await this._datacontext.SaveChangesAsync();
                    string message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                    "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> Congratulations! Your Bim-Edu Application Has Been Approved </span></h1><br/><br/>" +
                    "<div style='color:white;font-weight:bolder;text-align:center'>" +
                        "<a style='color:white;background-color:#e90172;padding:5px;text-decoration:none;' href='"+ _BaseUrl + "Account/Login" +"'> Click Here To Login </a><br/><br/>"+
                    "</div>" +
                    "</div>";
                   string message_subject = "BIM-EDU APPLICATION STATUS";
                
                await userEmailSender.EmailSender(_conf,applicationUser.Email,message_subject,message);
                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(currentApplicationForErrorLogging, ex.Message);
                return false;
            }
        }
        [HttpPost]
        public async Task<bool> ApplicationRejection(int ProgrammeApplicationId,string ApplicationUserId)
        {
            try{

                ProgrammeApplication programmeApplication = await this._datacontext.ProgrammeApplications.Where(p=> p.ProgrammeApplicationId == ProgrammeApplicationId)
                                    .FirstOrDefaultAsync();
                programmeApplication.isApproved = false;
                programmeApplication.isRejected = true;
                await this._datacontext.SaveChangesAsync();

                ApplicationUser applicationUser = await this._datacontext.AspNetUsers
                                                  .Where(predicate=>predicate.Id == ApplicationUserId)
                                                  .FirstOrDefaultAsync();

                programmeApplication.isRejected = false;
                programmeApplication.isApproved = true;
                await this._datacontext.SaveChangesAsync();
                    string message = "<div style='padding:20px;background:#4b345d;color:white;'>" +
                                      "<br/><br/>" +
                                        "<h1 style='color:white;font-weight:bolder;text-align:center;'><span style='color:white'> Sorry! Your Bim-Edu Application Has Been Rejected </span></h1>"+
                                      "<br/><br/>" +
                                    "</div>";
                   string message_subject = "BIM-EDU APPLICATION STATUS";
                
                await userEmailSender.EmailSender(_conf,applicationUser.Email,message_subject,message);
                return true;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(currentApplicationForErrorLogging, ex.Message);
                return false;
            }
        }

        public async Task<string> SaveFile(IFormFile IFormFile,string foldername)
        {
            try{

              string UploadedDocumentsFolder =  Path.Combine(this._environment.WebRootPath,foldername);
              string uniqueFileName = Guid.NewGuid().ToString() +  "_" + IFormFile.FileName;
              string filepath = Path.Combine(UploadedDocumentsFolder,uniqueFileName);
             await IFormFile.CopyToAsync(new FileStream(filepath,FileMode.Create));
              return uniqueFileName;
            }
            catch(Exception ex){
                _apierrorcontroller.WriteError(currentApplicationForErrorLogging, ex.Message);
                return null;
            }
           

        }


    }
}
