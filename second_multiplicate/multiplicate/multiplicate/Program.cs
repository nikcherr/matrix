using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Polinom pol = new Polinom();
            pol.Init();
            Polinom pol2 = new Polinom();
            pol2.Init();
            Console.WriteLine(pol.ToString());
            Console.WriteLine(pol2.ToString());
            Console.WriteLine("Результирующий полином");
            Polinom res = new Polinom();
            res.n = pol.n + pol2.n;
            res.koeff = new double[pol.n + pol2.n + 1];
            for (int i = 0; i <= pol.n; i++)
            {
                for (int j = 0; j <= pol2.n; j++)
                {
                    res.koeff[i + j] += pol.koeff[i] * pol2.koeff[j];
                }
            }
            Console.WriteLine(res.ToString());
            Console.ReadKey();
        }
    }

    class Polinom
    {
        public double[] koeff;
        public int n;
        public void Init()
        {
            Console.WriteLine("Степень полинома:");
            n = Convert.ToInt16(Console.ReadLine());
            koeff = new double[n + 1];
            Console.WriteLine("Коэффициенты:");
            for (int i = 0; i <= n; i++)
            {
                koeff[i] = Convert.ToInt16(Console.ReadLine());
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
