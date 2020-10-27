using AutoMapper;
using GestaoPonto.Application.Interfaces;
using GestaoPonto.Application.ViewModels;
using GestaoPonto.Domain.Interfaces;
using GestaoPonto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.Services
{
    public class PointRegisterService : IPointRegisterService
    {
        private readonly IMapper _mapper;
        private readonly IPointRegisterRepository _pointRegisterRepository;

        public PointRegisterService(IMapper mapper, IPointRegisterRepository pointRegisterRepository)
        {
            _mapper = mapper;
            _pointRegisterRepository = pointRegisterRepository;
        }
        public PointRegisterViewModel Add(PointRegisterViewModel pointRegisterViewModel)
        {
            return _mapper.Map<PointRegisterViewModel>(_pointRegisterRepository.Add(_mapper.Map<PointRegister>(pointRegisterViewModel)));
        }

        public void Dispose()
        {
            
        }
    }
}
