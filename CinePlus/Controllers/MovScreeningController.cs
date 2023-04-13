using CinePlus_BL.Dtos;
using CinePlus_BL.Services;
using CinePlus_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinePlus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovScreeningsController : ControllerBase
    {
        private readonly IMovScreeningService _movScreeningService;

        public MovScreeningsController(IMovScreeningService movScreeningService)
        {
            _movScreeningService = movScreeningService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MovScreening>> GetMovScreenings()
        {
            var movScreenings = _movScreeningService.GetMovScreenings();
            return Ok(movScreenings);
        }

        [HttpGet("{id}")]
        public ActionResult<MovScreening> GetMovScreening(int id)
        {
            var movScreening = _movScreeningService.GetMovScreening(id);
            if (movScreening == null)
            {
                return NotFound("The movie screening does not exist.");
            }
            return Ok(movScreening);
        }

        [HttpPost]
        public IActionResult CreateMovScreening(MovScreeningDto movScreeningDto)
        {
            try
            {
                _movScreeningService.SaveMovScreening(movScreeningDto);
                return Ok("Movie screening created successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the movie screening.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovScreening(int id, MovScreeningDto movScreeningDto)
        {
            try
            {
                _movScreeningService.UpdateMovScreening(movScreeningDto, id);
                return Ok("Movie screening updated successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while updating the mov screening.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovScreening(int id)
        {
            try
            {
                _movScreeningService.DeleteMovScreening(id);
                return Ok("Movie screening deleted successfully.");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while deleting the movie screening.");
            }
        }
    }
}
