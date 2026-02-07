namespace Arreglos_Bidimensionales_Segundo_Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CREACION DE MATRIZ BIDIMENSIONAL");
            Console.WriteLine("Ingrese la cantidad de filas queridas");
            int filas = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingrese la cantidad de columnas queridas");
            int columnas = int.Parse(Console.ReadLine()!);
            double[,] matriz = new double[filas, columnas];

            Console.WriteLine("INSERCION DE DATOS");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.WriteLine($"Ingrese el valor para la posicion [{i},{j}] de la matriz");
                    matriz[i, j] = double.Parse(Console.ReadLine()!);
                }
            }

            Console.WriteLine("IMPRESION DE DATOS, FORMA TABULAR");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            double mayorValor = matriz[0,0];
            double menorValor = matriz[0,0];
            int filaMayor = 0;
            int columnaMayor = 0;
            int filaMenor = 0;
            int columnaMenor = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i,j] > mayorValor)
                    {
                        mayorValor = matriz[i, j];
                        filaMayor = i;
                        columnaMayor = j;
                    }
                    if(matriz[i,j] < menorValor)
                    {
                        menorValor = matriz[i, j];
                        filaMenor = i;
                        columnaMenor = j;
                    }
                } 
            }
            Console.WriteLine($"MAYOR VALOR DENTRO DE LA MATRIZ: {mayorValor}, en la posición [{filaMayor}, {columnaMayor}]\nMENOR VALOR DENTRO DE LA MATRIZ: {menorValor}, en la posicion [{filaMenor}, {columnaMenor}]");

        }
    }
}
