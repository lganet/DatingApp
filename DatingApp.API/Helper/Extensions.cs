using DatingApp.API.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace DatingApp.API.Helper
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, System.Exception exception){

            if (! exception.GetType().IsSubclassOf(typeof(DatingAppException))){
                //response.Headers.Add("Application-Error", $"{exception.Message} -> Adcionado ao log por ser um erro não esperado!");
                response.Headers.Add("Content-Type", "text/html; charset=utf-8");
            }
            
            response.Headers.Add("Application-Error", $"{exception.Message}");
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");


            
        }
        
    }
}