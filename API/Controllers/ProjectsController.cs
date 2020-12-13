using Infrastructure.Commands.Project;
using Infrastructure.Constants;
using Infrastructure.DTO.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProjectsController>/5

        [HttpGet("{id}", Name = ProjectsControllerRoute.GetProject)]
        public IActionResult Get(int id, [FromServices] IGetProjectCommand command)
        {
            return command.Execute(id);
        }

        // POST api/<ProjectsController>
        [HttpPost("", Name = ProjectsControllerRoute.PostProject)]
        public IActionResult Post([FromBody] CreateProjectRequest postedProject, [FromServices] IPostProjectCommand command)
        {
            if (!ModelState.IsValid) return new BadRequestResult();
            return command.Execute(postedProject);
        }

        // PUT api/<ProjectsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
