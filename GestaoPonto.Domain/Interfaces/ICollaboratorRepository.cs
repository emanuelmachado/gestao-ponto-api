using GestaoPonto.Domain.Models;
using System.Collections.Generic;

namespace GestaoPonto.Domain.Interfaces
{
    public interface ICollaboratorRepository
    {

        /// <summary>
        /// Add - this method allow you to add a collaborator
        /// </summary>
        /// <param name="c">Object collaborator to be added</param>
        void Add(Collaborator c);

        /// <summary>
        /// Edit - this method allow you to edit a collaborator
        /// </summary>
        /// <param name="c">Object collaborator to be edited</param>
        void Edit(Collaborator c);

        /// <summary>
        /// Remove - this method allow you to remove a collaborator
        /// </summary>
        /// <param name="c">Object collaborator to be removed</param>
        void Remove(Collaborator c);

        /// <summary>
        /// GetAll - this method allow you to return all collaborator
        /// </summary>
        IEnumerable<Collaborator> GetAll();

        /// <summary>
        /// FindById - this method allow you to find a collaborator by its primary key
        /// </summary>
        /// <param name="CollaboratorId">Id of collaborator to be founded</param>
        Collaborator FindById(int CollaboratorId);
    }
}
