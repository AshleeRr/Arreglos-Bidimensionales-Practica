namespace Arreglos_Bidimensionales_Promedio_Estudiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] estudiantes = { "Maria", "Rosa", "Julia", "Miriam" };
            string[] asignaturas = { "Biologia", "Fisica", "Artes" };
            double[,] calificaciones = new double[4, 3];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                for (int j = 0; j < asignaturas.Length; j++)
                {
                    Console.WriteLine($"Ingrese la calificacion de {estudiantes[i]} en: {asignaturas[j]}");
                    calificaciones[i, j] = double.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("------------ Promedio de Estudiantes -------------");
            for (int i = 0; i < estudiantes.Length; i++)
            {
                double suma = 0;
                for (int j = 0; j < asignaturas.Length; j++)
                {
                    suma += calificaciones[i, j];
                }
                double promedio = suma / asignaturas.Length;
                Console.WriteLine($"Estudiante: {estudiantes[i]}\nPromedio: {Math.Round(promedio,2)}");
                Console.WriteLine("---------------------------------------");
            }

            Console.WriteLine("------------ Promedio de Asignaturas -------------");
            for (int j = 0; j < asignaturas.Length; j++)
            {
                double suma = 0;
                for (int i = 0; i < estudiantes.Length; i++)
                {
                    suma += calificaciones[i, j];
                }
                double promedio = suma / estudiantes.Length;
                Console.WriteLine($"Asignatura: {asignaturas[j]} \nPromedio: {Math.Round(promedio, 2)}");
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}
