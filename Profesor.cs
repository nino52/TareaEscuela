using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEscuela
{
    internal class Profesor : Persona
    {
        public List<Curso> Curso { get; set; }

        public Profesor(string nombre) : base(nombre) 
        {

            Curso = new List<Curso>();
        }

        public void AsignarCurso(Curso curso)
        {
            Curso.Add(curso);
        }
    }
}
