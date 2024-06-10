using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Exceptions
{
    public static class ConfigurationExceptionMiddlewear
    {
        public static void ConfigureExceptionHendlingMiddlewear(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddlewear>();
        }
    }
}
