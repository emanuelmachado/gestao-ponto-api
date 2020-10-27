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
    public class CollaboratorController : ControllerBase
    {
        private readonly ICollaboratorService _collaboratorService;

        public CollaboratorController(ICollaboratorService collaboratorService)
        {
            _collaboratorService = collaboratorService;
        }

        //Get: api/collaborator
        [HttpGet]
        public JsonResult GetCollaborator()
        {
            return new JsonResult(_collaboratorService.list());
        }

        //Get: api/collaborator/1
        [HttpGet("{CollaboratorId}")]
        public JsonResult GetCollaborator(int CollaboratorId)
        {
            return new JsonResult(_collaboratorService.filterByCollaboratorId(CollaboratorId));
        }
    }
}
