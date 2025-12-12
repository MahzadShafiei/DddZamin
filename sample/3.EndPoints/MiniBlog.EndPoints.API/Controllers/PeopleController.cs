using DDDZamin.EndPoints.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.Domain.People.ValueObjects;
using MiniBlog.Core.RequestResponse.People.Commands.Create;

namespace MiniBlog.EndPoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : BaseController
    {
        private readonly ILogger<PeopleController> _logger;

        public PeopleController(ILogger<PeopleController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetValueObjectEQ")]
        public IActionResult Get()
        {
            FirstName firstName1 = "Mahzad";
            FirstName firstName2 = "Mahzad";

            return Ok(firstName1 == firstName2);
        }

        [HttpGet("/GetlenException")]
        public IActionResult GetlenException()
        {
            try
            {
                FirstName firstName = new FirstName("a");
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok(ex.ToString());
            }
        }

        [HttpPost("/CreatePerson")]
        public async Task<IActionResult> CreatePerson([FromBody]CreatePerson createPerson)
        {
            return await Create<CreatePerson, int>(createPerson);
        }
    }
}
