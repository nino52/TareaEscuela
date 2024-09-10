using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TareaEscuela
{
    internal class Clase
    {
        public string Idclase { get; set; }
        public List<Profesor> Profesor { get; set; }
        public List<Estudiante> Estudiante { get; set; }

        public Clase(string idclase)
        {
            Idclase = idclase;
            Profesor = new List<Profesor>();
            Estudiante = new List<Estudiante>();

        }

        public void AsignarProfesor(Profesor profesor) 
            {
                Profesor.Add(profesor);
            }
            public void AgregarEstudiantes(Estudiante estudiante)
            
            {
                Estudiante.Add(estudiante);

        }
    }
}
