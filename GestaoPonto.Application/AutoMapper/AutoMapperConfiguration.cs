﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new ViewModelToDomainMappingProfile());
                ps.AddProfile(new DomainToViewModelMappingProfile());
            });
        }
    }
}
