using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using bim_edu.DataContect.Controllers;
using bim_edu.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bim_edu.Models.PaymentModel;
using System.Net.Http;
using System.Net.Http.Headers;

namespace bim_edu.APIs.Controllers
{
    public class ApiPaymentController : Controller
    {

        string currentApplicationForErrorLogging = "ApiPaymentController";
        BimEduDataContext _datacontext;
        ApiErrorController _apierrorcontroller;
        private IConfiguration _conf;
        private readonly IHostingEnvironment _environment;
        private static readonly HttpClient client = new HttpClient();

        public ApiPaymentController(BimEduDataContext datacontenxt,IConfiguration conf,IHostingEnvironment environment)
        {
            this._apierrorcontroller = new ApiErrorController(datacontenxt,conf,environment);
            this._datacontext = datacontenxt;
            this._conf = conf;
            this._environment = environment;

        } 

        public PaymentCredential PaymentCredential(){
            
            PaymentCredential paymentcredential = new PaymentCredential();

            paymentcredential.RunEnvironment = _conf.GetValue<string>("PaymentCredential:RunEnvironment");
            paymentcredential.ClientId = _conf.GetValue<string>("PaymentCredential:ClientId");
            paymentcredential.ClientSecret = _conf.GetValue<string>("PaymentCredential:ClientSecret");
            paymentcredential.AccessTokenUrl = _conf.GetValue<string>("PaymentCredential:AccessTokenUrl");
            paymentcredential.ExecutePaymentUrl = _conf.GetValue<string>("PaymentCredential:ExecutePaymentUrl");
            paymentcredential.NewStudentPaymentSuccessUrl = _conf.GetValue<string>("PaymentCredential:NewStudentPaymentSuccessUrl");
            paymentcredential.NewStudentPaymentCancelUrl = _conf.GetValue<string>("PaymentCredential:NewStudentPaymentCancelUrl");
            paymentcredential.OldStudentPaymentSuccessUrl = _conf.GetValue<string>("PaymentCredential:OldStudentPaymentSuccessUrl");
            paymentcredential.OldStudentPaymentCancelUrl = _conf.GetValue<string>("PaymentCredential:OldStudentPaymentCancelUrl");
            paymentcredential.BaseUrl = _conf.GetValue<string>("Bim-Edu:BaseUrl");

            return paymentcredential;
        }

        public IEnumerable<PaymentByPassCode> PaymentByPassCodes(){

            try{
                    List<PaymentByPassCode> passcodes = this._datacontext.PaymentByPassCodes
                                                .Where(predicate=>predicate.isremoved == false)
                                                .ToList();
                    return passcodes;
               }
               catch(Exception ex){
                    _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                    return null;
               }
        }
        public async Task<bool> PaymentByPassCodeGenerate(){

            try{
                    PaymentByPassCode lastcode = this._datacontext.PaymentByPassCodes.LastOrDefault();
                    PaymentByPassCode newcode = null;

                    if(lastcode == null){
                        newcode = new PaymentByPassCode(){
                            Code = GeneralStoredNames.Payment_By_Pass_Code_Format +  "0"
                        };
                    }else{
                        newcode = new PaymentByPassCode(){
                            Code = GeneralStoredNames.Payment_By_Pass_Code_Format +  lastcode.PaymentByPassCodeId.ToString()
                        };                    
                    }
                    this._datacontext.PaymentByPassCodes.Add(newcode);
                    await this._datacontext.SaveChangesAsync();
                    return true;
               }
               catch(Exception ex){
                    _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                    return false;
               }
        }
        public async Task<bool> PaymentByPassCodeCheckAndRemove(string Code, string ApplicationUserId){

            try{
                    PaymentByPassCode passcode = this._datacontext.PaymentByPassCodes
                                                .Where(predicate=>predicate.Code == Code && predicate.isremoved == false)
                                                .FirstOrDefault();
                    
                    if(passcode == null){
                        return false;
                    }else{
                        passcode.ApplicationUserId = ApplicationUserId;
                        passcode.date = DateTime.Now;
                        passcode.isremoved = true;   
                        await this._datacontext.SaveChangesAsync(); 
                        return true;                
                    }
               }
               catch(Exception ex){
                    _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                    return false;
               }
        }

        [HttpPost]
        public async Task<bool> StudentFeeToPayAdd(StudentFeeToPayViewModel model)
        {
          try{
                  StudentFeeToPay entity = new StudentFeeToPay(){
                            Amount =model.Amount,
                            Paid=model.Paid,
                            ProgrammeApplicationId=model.ProgrammeApplicationId,
                            DateInitiated = DateTime.Now,
                            Type = model.Type
                  };
                 await this._datacontext.StudentFeesToPay.AddAsync(entity);
                 await this._datacontext.SaveChangesAsync();
                 return true;
              
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
          }
        }

        [HttpPost]
        public async Task<bool> StudentFeeToPayUpdate(StudentFeeToPayViewModel model)
        {
          try{
              StudentFeeToPay result =  await this._datacontext.StudentFeesToPay
                                                .Where(predicate=>predicate.StudentFeeToPayId == model.StudentFeeToPayId)
                                                .FirstOrDefaultAsync();

                if(result != null){
                    result.Amount =model.Amount;
                    result.Paid=model.Paid;
                    result.Type = model.Type;
                    await this._datacontext.SaveChangesAsync();
                    return true;
                }

                return false;
          }
          catch(Exception  ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;
          }
        }
    
        [HttpPost]
        public async Task<bool> StudentFeeToPayDelete(int StudentFeeToPayId)
        {
          try{

                StudentFeeToPay result =  await this._datacontext.StudentFeesToPay
                                                .Where(predicate=>predicate.StudentFeeToPayId == StudentFeeToPayId)
                                                .FirstOrDefaultAsync();
                if(result != null){
                  result.isremoved = true;
                  await this._datacontext.SaveChangesAsync();
                  return true;
                }
                return false;
              }
              catch(Exception ex){
                _apierrorcontroller.WriteError(ex.Message,currentApplicationForErrorLogging);
                return false;

              }
        }
        

    }
}
