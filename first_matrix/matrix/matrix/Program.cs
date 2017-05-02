using System;

namespace matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            try
            {
                Console.WriteLine("Введите размер матрицы: ");
                n = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            int[,] matrix = new int[n, n];
            int[,] result = new int[n, n];
            Random rnd = new Random();
            //исходая симметрическая матрица размера Z
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > 0 && j < i)
                    {
                        matrix[i, j] = matrix[j, i];
                    }
                    else
                        matrix[i, j] = Convert.ToInt16(rnd.Next(0, 10).ToString());
                }
            }
            //вывод на консоль
            Console.Write("Исходная:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\nРезультирующая:\n");
            Result(n, matrix);
            Result_v2(n, matrix);
            Console.ReadKey();
        }

        public static void Result(int z, int[,] matrix)
        {
            int temp = 0;
            int iter = 0;
            int[,] result = new int[z, z];
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    for (int k = 0; k + i < z && k + j < z; k++)
                    {
                        temp += matrix[k + i, k + j];
                        iter++;
                    }
                    result[i, j] = temp;
                    temp = 0;
                }
            }
            Console.Write("Количество итераций:" + iter + "\n");
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
        public static void Result_v2(int z, int[,] matrix)
        {
            int temp = 0;
            int iter = 0;
            int[,] result = new int[z, z];
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    if (i > 0 && j < i)
                    {
                        result[i, j] = result[j, i];
                        iter++;
                        continue;
                    }
                    for (int k = 0; k + i < z && k + j < z; k++)
                    {
                        temp += matrix[k + i, k + j];
                        iter++;
                    }
                    result[i, j] = temp;
                    temp = 0;
                }
            }
            Console.Write("Количество итераций:" + iter + "\n");
            for (int i = 0; i < z; i++)
            {
                for (int j = 0; j < z; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
    }
}
