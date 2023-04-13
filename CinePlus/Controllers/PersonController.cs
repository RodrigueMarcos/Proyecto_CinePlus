using CinePlus_BL.Dtos;
using CinePlus_BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CinePlus_API.Controllers
{
    [ApiController]
    [Route("api/v1/person")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public IActionResult CreatePerson(PersonDto personDto)
        {
            try
            {
                _personService.SavePerson(personDto);
                return Ok("Person created successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the person.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePerson(int id, [FromBody] PersonDto personDto)
        {
            try
            {
                var person = _personService.GetPerson(id);

                if (person == null)
                {
                    return NotFound("The person does not exist.");
                }

                _personService.UpdatePerson(personDto, id);

                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while updating the person.");
            }
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            try
            {
                var people = _personService.GetPeople();
                return Ok(people);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while retrieving the people.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetPerson(int id)
        {
            try
            {
                var person = _personService.GetPerson(id);
                if (person == null)
                {
                    return NotFound();
                }
                return Ok(person);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while retrieving the person.");
            }
        }

    }
}
