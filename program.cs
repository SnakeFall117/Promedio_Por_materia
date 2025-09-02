using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_Por_Materia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroMaterias;
            string nombreMateria;
            double calificacion1, calificacion2, calificacion3, promedio, promediosemestre = 0;
            Console.Write("Ingrese el número de materias: ");
            numeroMaterias = int.Parse(Console.ReadLine());
            while (numeroMaterias < 3)
            {
                Console.WriteLine("Ingrese al menos 3 materias");
                numeroMaterias = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i <= numeroMaterias; i++)
            {
                    Console.Write($"Ingrese el nombre de la materia {i}: ");
                    nombreMateria = Console.ReadLine();
                    Console.Write($"Ingrese las calificación de {nombreMateria}: ");
                    calificacion1 = double.Parse(Console.ReadLine());
                    calificacion2 = double.Parse(Console.ReadLine());
                    calificacion3 = double.Parse(Console.ReadLine());
                double promedioMateria = (calificacion1 + calificacion2 + calificacion3) / 3.0;
                promediosemestre += promedioMateria;
                Console.WriteLine($"Promedio de {nombreMateria}: {promedioMateria:F2}");
            }
            promedio = promediosemestre / numeroMaterias;
            Console.WriteLine($"\nEl promedio de las calificaciones es: {promedio:F2}");
        }
    }
}
