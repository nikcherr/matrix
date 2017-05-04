using System;

namespace matrix
{
    class matrix
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Введите размер матрицы:");
            try
            {
                n = Convert.ToInt16(Console.ReadLine());
                //исходая симметрическая матрица размера N
                int[,] matrix = InitialMatrix(n);

                //вывод на консоль
                Console.Write("Исходная:\n" + RenderMatrix(matrix, n, " "));
                Console.Write("\nРезультирующая:\n");
                int[,] result = Result_v2(n, matrix);
                Console.WriteLine(RenderMatrix(result, n, "\t"));               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Инициализирует исходную симметрическую матрицу случайными значениями
        /// </summary>
        /// <param name="n">Размер матрицы</param>
        /// <returns>Симметрическая матрица</returns>
        public static int[,] InitialMatrix(int n)
        {
            Random rnd = new Random();
            int[,] result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > 0 && j < i)
                    {
                        result[i, j] = result[j, i];
                    }
                    else
                        result[i, j] = Convert.ToInt16(rnd.Next(0, 10).ToString());
                }
            }
            return result;
        }
        /// <summary>
        /// Вывод матрицы на консоль
        /// </summary>
        /// <param name="matrix">Матрица</param>
        /// <param name="n">Размерность матрицы</param>
        /// <param name="delimiter">Разделитель между элементами матрицы</param>
        /// <returns>Строка для вывода</returns>
        public static string RenderMatrix(int[,] matrix, int n, string delimiter)
        {
            string str = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    str += matrix[i, j] + delimiter;
                }
                str += "\n";
            }
            return str;
        }
        /// <summary>
        /// Получение результирующей матрицы
        /// </summary>
        /// <param name="n">Размерность</param>
        /// <param name="matrix">Исходная матрица</param>
        /// <returns></returns>
        public static int[,] Result(int n, int[,] matrix)
        {
            int temp = 0;
            int iter = 0;
            int[,] result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k + i < n && k + j < n; k++)
                    {
                        temp += matrix[k + i, k + j];
                        iter++;
                    }
                    result[i, j] = temp;
                    temp = 0;
                }
            }
            return result;
        }
        /// <summary>
        /// Оптимизированная функция получения результирующей матрицы
        /// </summary>
        /// <param name="n">Размерность</param>
        /// <param name="matrix">Исходная матрица</param>
        /// <returns>Результирующая матрица</returns>
        public static int[,] Result_v2(int n, int[,] matrix)
        {
            int temp = 0;
            int iter = 0;
            int[,] result = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i > 0 && j < i)
                    {
                        result[i, j] = result[j, i];
                        iter++;
                        continue;
                    }
                    for (int k = 0; k + i < n && k + j < n; k++)
                    {
                        temp += matrix[k + i, k + j];
                        iter++;
                    }
                    result[i, j] = temp;
                    temp = 0;
                }
            }
            return result;
        }
    }
}