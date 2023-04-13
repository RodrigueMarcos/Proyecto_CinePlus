using CinePlus_BL.Dtos;
using CinePlus_BL.Services;
using Microsoft.AspNetCore.Mvc;

namespace CinePlus_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovTheatersController : ControllerBase
    {
        private readonly IMovTheaterService _movTheaterService;

        public MovTheatersController(IMovTheaterService movTheaterService)
        {
            _movTheaterService = movTheaterService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var movTheaters = _movTheaterService.GetMovTheaters();
                return Ok(movTheaters);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred getting the Movies Theaters.");
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var movTheater = _movTheaterService.GetMovTheater(id);
                if (movTheater == null)
                {
                    return NotFound("The Movies Theater does not exist.");
                }
                return Ok(movTheater);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred getting the Movies Theater.");
            }
        }

        [HttpPost]
        public IActionResult Post(MovTheaterDto movTheaterDto)
        {
            try
            {
                _movTheaterService.SaveMovTheater(movTheaterDto);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred updating the Movies Theater.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, MovTheaterDto movTheaterDto)
        {
            try
            {
                _movTheaterService.UpdateMovTheater(movTheaterDto, id);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred creating the Movies Theater.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _movTheaterService.DeleteMovTheater(id);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred deleting the Movies Theater.");
            }
        }
    }

}
