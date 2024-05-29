using Microsoft.Extensions.DependencyInjection;
using OnionAplication.Interface.AutoMappers;
using OnionMapper.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionMapper
{
    public static class Registration
    {
        public static void AddAutoMappers( this IServiceCollection services)
        {
            services.AddSingleton<IMapper,Mapper>();
        }
    }
}
