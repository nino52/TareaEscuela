using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una clase
            Clase clase1 = new Clase("Clase A");

            // Crear profesores
            Profesor profesor1 = new Profesor("Prof. Juan");
            Profesor profesor2 = new Profesor("Prof. María");

            // Crear cursos
            Curso curso1 = new Curso("Matemáticas", 10, 5);
            Curso curso2 = new Curso("Historia", 8, 3);

            // Asignar cursos a los profesores
            profesor1.AsignarCurso(curso1);
            profesor2.AsignarCurso(curso2);

            // Asignar profesores a la clase
            clase1.AsignarProfesor(profesor1);
            clase1.AsignarProfesor(profesor2);

            // Crear estudiantes
            Estudiante estudiante1 = new Estudiante("Pedro", 1);
            Estudiante estudiante2 = new Estudiante("Lucía", 2);

            // Agregar estudiantes a la clase
            clase1.AgregarEstudiantes(estudiante1);
            clase1.AgregarEstudiantes(estudiante2);

            // Imprimir información de la clase
            Console.WriteLine($"Clase: {clase1.Idclase}");
            Console.WriteLine("Profesores:");
            foreach (var profesor in clase1.Profesor)
            {
                Console.WriteLine($"- {profesor.Nombre}");
                foreach (var curso in profesor.Curso)
                {
                    Console.WriteLine($"  Curso: {curso.Nombre}, Recuento de clases: {curso.RecuentoClases}, Recuento de ejercicios: {curso.RecuentoEjercicios}");
                }
            }

            Console.WriteLine("Estudiantes:");
            foreach (var estudiante in clase1.Estudiante)
            {
                Console.WriteLine($"- {estudiante.Nombre} (Número único: {estudiante.NumeroUnico})");
            }
        }
    }
}
