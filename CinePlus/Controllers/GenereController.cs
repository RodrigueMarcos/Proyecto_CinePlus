using CinePlus_BL.Dtos;
using CinePlus_BL.Services;
using CinePlus_DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinePlus_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneresController : ControllerBase
    {
        private readonly IGenereService _genereService;

        public GeneresController(IGenereService genereService)
        {
            _genereService = genereService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Genere>> GetGeneres()
        {
            var generes = _genereService.GetGeneres();
            return Ok(generes);
        }

        [HttpGet("{id}")]
        public ActionResult<Genere> GetGenere(int id)
        {
            var genere = _genereService.GetGenere(id);
            if (genere == null)
            {
                return NotFound("The genere does not exist.");
            }
            return Ok(genere);
        }

        [HttpPost]
        public IActionResult CreateGenere(GenereDTO genereDto)
        {
            try
            {
                _genereService.SaveGenere(genereDto);
                return Ok("Genere created successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while creating the genere.");
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateGenere(int id, GenereDTO genereDto)
        {
            try
            {
                _genereService.UpdateGenere(genereDto, id);
                return Ok("Genere updated successfully.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while updating the genere.");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteGenere(int id)
        {
            try
            {
                _genereService.DeleteGenere(id);
                return Ok("Genere deleted successfully.");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while deleting the genere.");
            }
        }

        [HttpGet("{id}/movies")]
        public ActionResult<IEnumerable<Movie>> GetMoviesByGenere(int id)
        {
            try
            {
                var movies = _genereService.GetMoviesByGenere(id).ToList();
                if (movies.Count == 0)
                {
                    return NotFound("No movies found for this genere.");
                }
                return Ok(movies);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while getting movies for the genere.");
            }
        }
    }
}
