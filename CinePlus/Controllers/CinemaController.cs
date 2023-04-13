using CinePlus_BL.Dtos;
using CinePlus_BL.Services;
using CinePlus_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinePlus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly ICinemaService _cinemaService;

        public CinemasController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cinema>> GetCinemas()
        {
            var cinemas = _cinemaService.GetCinemas();
            return Ok(cinemas);
        }

        [HttpGet("{id}")]
        public ActionResult<Cinema> GetCinema(int id)
        {
            var cinema = _cinemaService.GetCinema(id);
            if (cinema == null)
            {
                return NotFound("The cinema does not exist.");
            }
            return Ok(cinema);
        }

        [HttpPost]
        public IActionResult CreateCinema(CinemaDto cinemaDto)
        {
            try
            {
                _cinemaService.SaveCinema(cinemaDto);
                return Ok("Cinema created successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the cinema.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCinema(int id, CinemaDto cinemaDto)
        {
            try
            {
                _cinemaService.UpdateCinema(cinemaDto, id);
                return Ok("Cinema updated successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while updating the cinema.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCinema(int id)
        {
            try
            {
                _cinemaService.DeleteCinema(id);
                return Ok("Cinema deleted successfully.");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while deleting the cinema.");
            }
        }
    }
}
