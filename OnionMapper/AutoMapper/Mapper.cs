﻿using AutoMapper;
using AutoMapper.Internal;
using OnionAplication.Interface.AutoMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMapper = AutoMapper.IMapper;

namespace OnionMapper.AutoMapper
{
    public class Mapper : OnionAplication.Interface.AutoMappers.IMapper
    {
        public static List<TypePair> typePairs = new();
        private IMapper mappercontainer;

        public TDestination Map<TDestination, TSource>(TSource source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return mappercontainer.Map<TSource, TDestination>(source);
        }

        public IList<TDestination> Map<TDestination, TSource>(IList<TSource> source, string? ignore = null)
        {
            Config<TDestination, TSource>(5, ignore);
            return mappercontainer.Map<IList<TSource>, IList<TDestination>>(source);
        }

        public TDestination Map<TDestination>(object source, string? ignore = null)
        {
            Config<TDestination,object>(5, ignore);
            return mappercontainer.Map< TDestination>(source);
        }

        public IList<TDestination> Map<TDestination>(IList<object> source, string? ignore = null)
        {
            Config<TDestination, IList<object>>(5, ignore);
            return mappercontainer.Map<IList<TDestination>>(source);
        }

        protected void Config<TDestination, TSource>(int depth = 5, string? ignore = null)
        {
            var typepair = new TypePair(typeof(TSource), typeof(TDestination));
            if (typePairs.Any(a => a.DestinationType == typepair.DestinationType && a.SourceType == typepair.SourceType) && ignore is null)
                return;
            typePairs.Add(typepair);
            var config = new MapperConfiguration(cfg =>
            {
                foreach ( var item in typePairs)
                {
                    if (ignore is not null)
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ForMember(ignore, x => x.Ignore()).ReverseMap();
                    else
                        cfg.CreateMap(item.SourceType, item.DestinationType).MaxDepth(depth).ReverseMap();
                }
                    
            });
            mappercontainer = config.CreateMapper();
        }
    }
}
