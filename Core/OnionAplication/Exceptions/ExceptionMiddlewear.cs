using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Exceptions
{
    public class ExceptionMiddlewear : IMiddleware
    {
        public async Task InvokeAsync(HttpContext httpcontext, RequestDelegate next)
        {
            try
            {
                await next(httpcontext);
            }
            catch (Exception ex) 
            {
                await HadleExecptionAsync(httpcontext, ex);
            }
        }
        private static Task HadleExecptionAsync(HttpContext httpContext,Exception exception)
        {
            int statuscode = GetStatusCode(exception);
            httpContext.Response.ContentType ="application/json";
            httpContext.Response.StatusCode = statuscode;

            List<string> erorx = new()
            {
               $"ErorMessage :{exception.Message}" ,
                $"ErorDesciription :{exception.InnerException?.ToString()}"    
            };

            return httpContext.Response.WriteAsync( new ExceptionModel
            {
                Errors = erorx,
                StatusCode = statuscode
            }.ToString());
            

        }
        private static int GetStatusCode(Exception exception) =>
            exception switch
            {
                BadRequestException => StatusCodes.Status400BadRequest,
                NotFoundException => StatusCodes.Status400BadRequest,
                ValidationException => StatusCodes.Status422UnprocessableEntity,
                _ => StatusCodes.Status500InternalServerError
            };

    }
}
