using ApiRest.Modelos;
using ApiRest.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlumnoController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            Alumnos Alumno = new Alumnos();
            return Ok(Alumno.ObtenerAlumno());
        }

        [HttpPost("agregar")]
        public IActionResult AgregarAlumno(Alumno nuevoAlumno)
        {
            Alumnos alumno = new Alumnos();
            alumno.Agregar(nuevoAlumno);
            return CreatedAtAction(nameof(AgregarAlumno), nuevoAlumno);
        }
    }
}
