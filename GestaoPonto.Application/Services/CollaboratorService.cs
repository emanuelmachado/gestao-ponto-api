using AutoMapper;
using GestaoPonto.Application.Interfaces;
using GestaoPonto.Application.ViewModels;
using GestaoPonto.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoPonto.Application.Services
{
    public class CollaboratorService : ICollaboratorService
    {
        private readonly IMapper _mapper;
        private readonly ICollaboratorRepository _collaboratorRepository;

        public CollaboratorService(IMapper mapper, ICollaboratorRepository collaboratorRepository)
        {
            _mapper = mapper;
            _collaboratorRepository = collaboratorRepository;
        }

        public IEnumerable<CollaboratorViewModel> list()
        {   
            return _mapper.Map<IEnumerable<CollaboratorViewModel>>(_collaboratorRepository.GetAll());
        }

        public IEnumerable<CollaboratorViewModel> filterByCollaboratorId(int CollaboratorId)
        {
            return _mapper.Map<IEnumerable<CollaboratorViewModel>>(_collaboratorRepository.GetAll().Where(c => c.Id == CollaboratorId));
        }

        public void Dispose()
        {
        }


    }
}
