using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CFA.Services;
using CFA.API.DTO;

namespace CFA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CFAController : ControllerBase
    {
        private readonly IServices _services;
        public CFAController(IServices service)
        {
            _services = service;
        }

        [HttpPost]
        [Route("result")]
        public ActionResult Score([FromBody]DTOStream stream)
        {
            int result = _services.Add(stream.Input);
            if (result != -1)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("");
            }
        }

    }
}