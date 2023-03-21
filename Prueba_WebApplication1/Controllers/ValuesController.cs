using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CinePlus;
using CinePlus_DAL.Models;


namespace CinePlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //field privado de solo lectura
        private readonly ProyectoDevlightDB _context;

        //Inyección de dependencia
        //Dependency injection
        public PersonController(ProyectoDevlightDB context)
        {
            _context = context;
        }

        //Traer todo
        [HttpGet]
        public List<Person> GetPerson()
        {
            return _context.Person.ToList();
        }
    }
}
