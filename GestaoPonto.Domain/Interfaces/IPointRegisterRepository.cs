using GestaoPonto.Domain.Models;
using System.Collections.Generic;

namespace GestaoPonto.Domain.Interfaces
{
    public interface IPointRegisterRepository
    {
        /// <summary>
        /// Add - this method allow you to add a collaborator's point register
        /// </summary>
        /// <param name="p">Object collaborator's point register to be added</param>
        PointRegister Add(PointRegister p);

        /// <summary>
        /// Edit - this method allow you to edit a collaborator's point register
        /// </summary>
        /// <param name="p">Object collaborator to be edited</param>
        PointRegister Edit(PointRegister p);

        /// <summary>
        /// Remove - this method allow you to remove a collaborator's point register
        /// </summary>
        /// <param name="p">Object collaborator's point register to be removed</param>
        void Remove(PointRegister p);

        /// <summary>
        /// GetCollaborators - this method allow you to return all collaborator's point registers
        /// </summary>
        IEnumerable<PointRegister> GetAll();

        /// <summary>
        /// FindById - this method allow you to find a collaborator's point register by its primary key
        /// </summary>
        /// <param name="PointRegisterId">Id of collaborator's point register to be founded</param>
        PointRegister FindById(int PointRegisterId);
    }
}
