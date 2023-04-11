using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CinePlus;
using CinePlus_DAL.Models;
using CinePlus_BL.Services;
using CinePlus_BL.Dtos;

namespace CinePlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //field privado de solo lectura
        private readonly IPersonService _questionsService;

        //Inyección de dependencia
        //Dependency injection
        public UserController(IPersonService questionsService)
        {
            _questionsService = questionsService;
        }

        //Crear
        [HttpPost]
        public String PostUser(UserDto user)
        {
            String r = "OK";
            //_questionsService.SavePerson(person);
            return r;
        }

    }

}