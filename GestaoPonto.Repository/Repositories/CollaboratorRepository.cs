using GestaoPonto.Domain.Interfaces;
using GestaoPonto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Repository.Repositories
{
    public class CollaboratorRepository : Repository<Collaborator>, ICollaboratorRepository
    {
        public void Edit(Collaborator c)
        {
            Update(c);
        }

        public Collaborator FindById(int CollaboratorId)
        {
            return GetById(CollaboratorId);
        }

        public void Remove(Collaborator c)
        {
            Remove(c.Id);
        }

        void ICollaboratorRepository.Add(Collaborator c)
        {
            Add(c);
        }
    }
}
