using AutoMapper;
using GestaoPonto.Application.ViewModels;
using GestaoPonto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CollaboratorViewModel, Collaborator>();
            CreateMap<PointRegisterViewModel, PointRegister>();
        }
    }
}
