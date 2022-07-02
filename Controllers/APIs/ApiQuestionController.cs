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
using bim_edu.UserDefined.Functions;

namespace bim_edu.APIs.Controllers
{
    public class ApiQuestionController : Controller
    {

        string currentApplicationForErrorLogging = "ApiQuestionController";
        BimEduDataContext _datacontext;
        ApiErrorController _apierrorcontroller;
        private IHostingEnvironment _environment;
        private IConfiguration _conf;
        public ApiQuestionController(BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._apierrorcontroller = new ApiErrorController(datacontenxt,conf,environment);
            this._datacontext = datacontenxt;
            this._conf = conf;
            this._environment = environment;
        } 
        
        [HttpGet]
        public IEnumerable<Question> GetAllQuestionsByProgramId(int ProgramId)
        {
            IEnumerable<Question> result =   this._datacontext.Questions
                                              .Where(p=>p.isremoved == false && p.ProgrammeId == ProgramId)
                                              .Include("Program")
                                              .Include("Course")
                                              .Include("QuestionStudentProvidedSolutions.QuestionLecturerEvaluateStudentSolutions")
                                              .ToList();
            return result;
        }

        [HttpPost]
        public async Task<bool> QuestionAdd(QuestionViewModel model)
        {
          try{
              model.FilePath = await userFileSaver.SaveFile(model.IFormFile, this._environment,GeneralStoredNames.Questions_Directory);
              if(model.FilePath != null){
                  Question entity = new Question(){
                  Description = model.Description,
                  FilePath = model.FilePath,
                  ProgrammeId = model.ProgramId,
                  CourseId = model.CourseId
                  };
                 await this._datacontext.Questions.AddAsync(entity);
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
        public async Task<bool> QuestionDelete(int QuestionId)
        {
          try{
              Question question = await this._datacontext.Questions.Where(predicate=>predicate.QuestionId == QuestionId).FirstOrDefaultAsync();
              if(question != null){
                  question.isremoved = true;
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
        public async Task<bool> QuestionStudentProvidedSolutionAdd(QuestionStudentProvidedSolutionViewModel model)
        {
          try{
              model.FilePath = await userFileSaver.SaveFile(model.IFormFile, this._environment,GeneralStoredNames.Questions_Directory);
              if(model.FilePath != null){
                  QuestionStudentProvidedSolution entity = new QuestionStudentProvidedSolution(){
                  FilePath = model.FilePath,
                  QuestionId = model.QuestionId,
                  ApplicationUserId = model.ApplicatioinUserId
                  };
                 await this._datacontext.QuestionStudentProvidedSolutions.AddAsync(entity);
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
        public async Task<bool> QuestionStudentProvidedSolutionDelete(int QuestionStudentProvidedSolutionId)
        {
          try{
            
              QuestionStudentProvidedSolution item = await this._datacontext.QuestionStudentProvidedSolutions
                                        .Where(predicate=>predicate.QuestionStudentProvidedSolutionId == QuestionStudentProvidedSolutionId)
                                        .FirstOrDefaultAsync();
              if(item != null){
                  item.isremoved = true;
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
        public async Task<bool> QuestionLecturerEvaluateStudentSolutionAdd(QuestionLecturerEvaluateStudentSolutionViewModel model)
        {
          try{
              model.FilePath = await userFileSaver.SaveFile(model.IFormFile, this._environment,GeneralStoredNames.Questions_Directory);
              if(model.FilePath != null){
                  QuestionLecturerEvaluateStudentSolution entity = new QuestionLecturerEvaluateStudentSolution(){
                  FilePath = model.FilePath,
                  QuestionStudentProvidedSolutionId = model.QuestionStudentProvidedSolutionId
                  };
                 await this._datacontext.QuestionLecturerEvaluateStudentSolutions.AddAsync(entity);
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
        public async Task<bool> QuestionLecturerEvaluateStudentSolutionDelete(int QuestionLecturerEvaluateStudentSolutionId)
        {
          try{
            
              QuestionLecturerEvaluateStudentSolution item = await this._datacontext.QuestionLecturerEvaluateStudentSolutions
                                        .Where(predicate=>predicate.QuestionLecturerEvaluateStudentSolutionId == QuestionLecturerEvaluateStudentSolutionId)
                                        .FirstOrDefaultAsync();
              if(item != null){
                  item.isremoved = true;
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

    }
}
