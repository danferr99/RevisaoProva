using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REVISAO_PROVA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Listagem de times");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok("Listagem de um time");
        }
        [HttpPost]
        public async Task<IActionResult> Post(Model.Time time)
        {
            return Ok("Time cadastrado!!!");
        }


    }
}
