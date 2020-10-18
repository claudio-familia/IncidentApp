﻿using IncidentApp.Controllers.Base;
using IncidentApp.Models;
using IncidentApp.Models.Dtos;
using IncidentApp.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class IncidentController : BaseController<Incident, IncidentDto>
    {
        public IncidentController(IBaseService<Incident, IncidentDto> _baseService) : base(_baseService)
        {
        }
    }
}