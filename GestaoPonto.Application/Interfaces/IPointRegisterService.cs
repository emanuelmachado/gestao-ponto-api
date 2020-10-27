using GestaoPonto.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.Interfaces
{
    public interface IPointRegisterService : IDisposable
    {
        PointRegisterViewModel Add(PointRegisterViewModel pointRegisterViewModel);
    }
}
