using AutoMapper;
using GestaoPonto.Application.ViewModels;
using GestaoPonto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Collaborator, CollaboratorViewModel>();
            CreateMap<PointRegister, PointRegisterViewModel>();
        }
    }
}
