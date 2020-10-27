using GestaoPonto.Domain.Interfaces;
using GestaoPonto.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Repository.Repositories
{
    public class PointRegisterRepository : Repository<PointRegister>, IPointRegisterRepository
    {
        public PointRegister Edit(PointRegister p)
        {
            return Update(p);
        }

        public PointRegister FindById(int PointRegisterId)
        {
            return GetById(PointRegisterId);
        }

        public void Remove(PointRegister p)
        {
            Remove(p.Id);
        }

        PointRegister IPointRegisterRepository.Add(PointRegister p)
        {
            return Add(p);
        }
    }
}
