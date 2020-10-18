﻿using IncidentApp.Controllers.Base;
using IncidentApp.Models;
using IncidentApp.Models.Dtos;
using IncidentApp.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace IncidentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparmentController : BaseController<Department, DepartmentDto>
    {
        public DeparmentController(IBaseService<Department, DepartmentDto> _baseService) : base(_baseService)
        {
        }
    }
}
