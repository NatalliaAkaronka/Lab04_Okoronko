using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Okoronko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Циклы с контролем за монотонной велечиной";
            Console.Write("Введите точность: ");
            double точность = Convert.ToDouble(Console.ReadLine());
            double s = 0;
            double k = 1;
            while (Math.Abs(1/(2*k-1)/(2*k+1))>точность)
            {
                s += (1 / (2 * k - 1) / (2 * k + 1));
                k++;


            }
            string txt = "Сумма слагаемых равна: ";
            Console.WriteLine(txt + s);
            Console.ReadLine();
        }
    }
}
