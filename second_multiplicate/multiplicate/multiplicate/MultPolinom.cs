using System;

namespace multiplicate
{
    public class MultPolinom
    {
        static void Main(string[] args)
        {
            //инициализация полиномов
            try
            {
                Polinom pol = new Polinom();
                pol.Init();
                Polinom pol2 = new Polinom();
                pol2.Init();
                //вывод на консоль
                Console.WriteLine(pol.ToString());
                Console.WriteLine(pol2.ToString());
                //вывод на консоль произведения полиномов 
                Console.WriteLine("Результирующий полином:");  
                Console.WriteLine(Multiplication(pol, pol2).ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Умножение полиномов
        /// </summary>
        /// <param name="pol">Первый полином</param>
        /// <param name="pol2">Второй полином</param>
        /// <returns>Результирующий полином</returns>
        public static Polinom Multiplication(Polinom pol, Polinom pol2)
        {
            Polinom res = new Polinom(pol.n + pol2.n, new double[pol.n + pol2.n + 1]);
            for (int i = 0; i <= pol.n; i++)
            {
                for (int j = 0; j <= pol2.n; j++)
                {
                    res.koeff[i + j] += pol.koeff[i] * pol2.koeff[j];
                }
            }
            return res;
        }
    } 
    /// <summary>
    /// Предоставляет объект полином
    /// </summary>
    public class Polinom
    {
        public double[] koeff;
        public int n;
        public Polinom() { }
        public Polinom(int n, double[] koeff)
        {
            this.n = n;
            this.koeff = koeff;
        }
        public void Init()
        {
            try
            {
                Console.WriteLine("Введите степень полинома:");
                n = Convert.ToInt16(Console.ReadLine());
                koeff = new double[n + 1];
                Console.WriteLine("Введите коэффициенты:");
                for (int i = 0; i <= n; i++)
                {
                    koeff[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch
            {
                throw new Exception("Ошибка ввода.");
            }
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i <= n; i++)
            {
                res += koeff[i] + "x^" + i + "+";
            }
            return res.Substring(0, res.Length - 1);
        }
    }
   
}