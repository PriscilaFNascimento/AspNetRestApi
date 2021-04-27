using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetRestApi.Business.Implementations;
using AspNetRestApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AspNetRestApi.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonBusiness _personBusiness;
        public PersonController(ILogger<PersonController> logger, IPersonBusiness personBusiness)
        {
            _logger = logger;
            _personBusiness = personBusiness;
        }

        [HttpGet("getAll")]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }
        
        [HttpGet("getById/{id}")]
        public IActionResult GetById(long id)
        {
            return Ok(_personBusiness.FindById(id));
        }

        [HttpPost("create")]
        public IActionResult Create(Person person)
        {
            return Ok(_personBusiness.Create(person));
        }

        [HttpPatch("update")]
        public IActionResult Update(Person person)
        {
            return Ok(_personBusiness.Update(person));
        }

        [HttpDelete("delete/{id}")]
        public IActionResult Delete(long id)
        {
            _personBusiness.Delete(id);
            return Ok("Removido com sucesso");
        }
    }
}
