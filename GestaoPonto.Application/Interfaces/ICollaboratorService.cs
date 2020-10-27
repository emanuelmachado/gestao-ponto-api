using GestaoPonto.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.Interfaces
{
    public interface ICollaboratorService : IDisposable
    {
        IEnumerable<CollaboratorViewModel> list();

        IEnumerable<CollaboratorViewModel> filterByCollaboratorId(int CollaboratorId);
    }
}
