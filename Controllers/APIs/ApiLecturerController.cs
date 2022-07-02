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

namespace bim_edu.APIs.Controllers
{
    public class ApiLecturerController : Controller
    {

        string currentApplicationForErrorLogging = "ApiLecturerController";
        BimEduDataContext _datacontext;
        ApiErrorController _apierrorcontroller;
        public ApiLecturerController(BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._apierrorcontroller = new ApiErrorController(datacontenxt,conf,environment);
            this._datacontext = datacontenxt;
        } 
        
        [HttpGet]
        public IEnumerable<Lecturer> GetAllLecturers()
        {
            IEnumerable<Lecturer> result =      this._datacontext.Lecturers
                                                .Where(p=>p.isremoved == false)
                                                .Include("ApplicationUser")
                                                .ToList();
            return result;
        }
        
        [HttpGet]
        public async Task<IEnumerable<Course>> CourseAll()
        {
            IEnumerable<Course> result =  await this._datacontext.Courses
                                            .Where(p=>p.isremoved == false )
                                            .ToListAsync();
            return result;
        }

        [HttpPost]
        public async Task<bool> CourseAdd(Course entity)
        {
          try{
              Course doesCourseExist = await this._datacontext.Courses
                                      .Where(predicate=>predicate.Name.ToLower() == entity.Name.ToLower())
                                      .FirstOrDefaultAsync();
                                      
              if(doesCourseExist == null){
                await this._datacontext.Courses.AddAsync(entity);
                await this._datacontext.SaveChangesAsync();
                return true;
              }else{
                return false;
              }

            }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
          }
        }

        [HttpPost]
        public async Task<bool> CourseRemove(int courseLecturerId)
        {
          try{
              Course entity =  await this._datacontext.Courses.Where(predicate=> predicate.CourseId == courseLecturerId).FirstOrDefaultAsync();
              entity.isremoved = true;
              await this._datacontext.SaveChangesAsync();
              return true;
            }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
          }
        }
        
        [HttpGet]
        public async Task<IEnumerable<CourseLecturer>> GetAllCourseLecturersForAProgram(int ProgramId)
        {
            IEnumerable<CourseLecturer> result =  await this._datacontext.CourseLecturers
                                            .Where(p=>p.isremoved == false && p.ProgrammeId == ProgramId)
                                            .Include("Lecturer.ApplicationUser")
                                            .Include("Course")
                                            .ToListAsync();
            return result;
        }

        [HttpPost]
        public async Task<string> AddANewLecturer(Lecturer entity)
        {
          try{
              await this._datacontext.Lecturers.AddAsync(entity);
              await this._datacontext.SaveChangesAsync();
              return GeneralStoredNames.Success;
            }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return GeneralStoredNames.Error;
          }
        }

        [HttpPost]
        public async Task<string> AddANewCourseLecturer(CourseLecturerViewModel model)
        {
          try{

              await this._datacontext.CourseLecturers.AddAsync(model);
              await this._datacontext.SaveChangesAsync();
              return GeneralStoredNames.Success;
            }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return GeneralStoredNames.Error;
          }
        }

        [HttpPost]
        public async Task<string> RemoveOldCourseLecturer(int courseLecturerId)
        {
          try{
              CourseLecturer courseLecturer =  await this._datacontext.CourseLecturers.Where(predicate=> predicate.CourseLecturerId == courseLecturerId).FirstOrDefaultAsync();
              courseLecturer.isremoved = true;
              await this._datacontext.SaveChangesAsync();
              return GeneralStoredNames.Success;
            }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return GeneralStoredNames.Error;
          }
        }


    }
}
