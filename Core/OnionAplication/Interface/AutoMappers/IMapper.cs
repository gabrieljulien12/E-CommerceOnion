﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAplication.Interface.AutoMappers
{
    public interface IMapper
    {
        TDestination Map<TDestination,TSource>(TSource source, string? ignore = null); 
        IList<TDestination> Map< TDestination, TSource>( IList<TSource> source, string? ignore = null);
        TDestination Map<TDestination>(object source, string? ignore = null);
        IList <TDestination> Map<TDestination>( IList<object> source, string? ignore = null);
    }
}
