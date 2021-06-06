using ApiRest.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Repositorio
{
    public class Alumnos
    {
        public static List<Alumno> _listaAlumnos = new List<Alumno>()
        {
            new Alumno() { Id = 1, Nombre = "Alumno 1" , Apellido = "Apellido 1" },
            new Alumno() { Id = 2, Nombre = "Alumno 2" , Apellido = "Apellido 2" },
            new Alumno() { Id = 3, Nombre = "Alumno 3" , Apellido = "Apellido 3" }
        };

        public IEnumerable<Alumno> ObtenerAlumno()
        {
            return _listaAlumnos;
        }

        public void Agregar(Alumno nuevoAlumno)
        {
            _listaAlumnos.Add(nuevoAlumno);
        }
    }
}
