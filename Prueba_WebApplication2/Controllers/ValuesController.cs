using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prueba_WebApplication2.Models;

namespace Prueba_WebApplication2.Controllers
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
        /*
         * //Traer todo
        [HttpGet]
        public List<Pregunta> GetQuestions()
        {
            return _questionsService.GetQuestions().ToList();
        }

        //Traer 1
        [HttpGet("{id}")]
        public Pregunta GetQuestion(int id)
        {
            return _questionsService.GetQuestion(id);
        }

        //Buscar preguntas por texto
        [HttpGet("search/{text}")]
        public List<Pregunta> SearchQuestion(string text)
        {
            return _questionsService.SearchQuestions(text).ToList();
        }

        //Crear
        [HttpPost]
        public void PostQuestion(PreguntaDto preguntaDto)
        {
            _questionsService.SaveQuestion(preguntaDto);
        }

        //Actualizar 1
        [HttpPut("{id}")]
        public void PutQuestion(int id, PreguntaDto preguntaDto)
        {
            _questionsService.UpdateQuestion(preguntaDto, id);
        }

        //Borrar 1
        [HttpDelete("{id}")]
        public void DeleteQuestion(int id)
        {
            _questionsService.DeleteQuestion(id);
        }
         */
    }
}
