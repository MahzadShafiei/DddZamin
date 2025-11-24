using Microsoft.AspNetCore.Mvc;
using MiniBlog.Core.Domain.People.Entities;
using MiniBlog.Core.Domain.People.ValueObjects;

namespace MiniBlog.EndPoints.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
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

        [HttpGet("/CreatePerson")]
        public IActionResult CreatePerson()
        {
            try
            {
                PersonEventBase person = new PersonEventBase(1,"Mahzad","Shafiei");
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok(ex.ToString());
            }
        }
    }
}
