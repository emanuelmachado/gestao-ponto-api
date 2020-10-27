using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoPonto.Application.Interfaces;
using GestaoPonto.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoPonto.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointRegisterController : ControllerBase
    {
        private readonly IPointRegisterService _pointRegisterService;

        public PointRegisterController(IPointRegisterService pointRegisterService)
        {
            _pointRegisterService = pointRegisterService;
        }

        [HttpPost]
        public JsonResult Index(PointRegisterViewModel pointRegisterViewModel)
        {
            PointRegisterViewModel objAdded = _pointRegisterService.Add(pointRegisterViewModel);

            return new JsonResult(objAdded);
        }
    }
}
