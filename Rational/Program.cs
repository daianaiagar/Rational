using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti prima fractie:");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"prima fractie = {m}/{n}");
            Console.WriteLine("Introduceti a doua fractie:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a doua fractie = {a}/{b}");
            Console.WriteLine(" ");
            operatii(m, n, a, b);
            comparati(m, n, a, b);
            Console.WriteLine("introduceti o putere");
            int p = int.Parse(Console.ReadLine());
            putere(m, n, p);
            putere(a, b, p);
            Console.WriteLine("verificam daca putem aducem ambele fractii la o forma ireductiblila");
            simplificare(a, b);
            simplificare(m, n);
            Console.WriteLine("adunarea ireductibila a fractiilor este:");
            ireductibil(m, n, a, b);
        }
        static void operatii(int m, int n, int a, int b)
        {
            double adunare = (m * b + a * n) / (n * b);
            int ad2 = n * b;
            int ad1 = (m * b) + (a * n);
            int ad3 = (m * b) - (a * n);
            int ad4 = m * a;
            double diferenta = ((m * b) - (a * n)) / (n * b);
            Console.WriteLine($"{m}/{n} + {a}/{b} ={ad1}/{ad2}= {adunare}");
            Console.WriteLine($"{m}/{n} - {a}/{b} ={ad1}/{ad3}= {diferenta}");
            double i = (m * a) / (n * b);
            Console.WriteLine($"{m}/{n} * {a}/{b} ={ad4}/{ad2}= {i}");
            double imp = (m * b) / (n * a);
            Console.WriteLine($"{m}/{n} : {a}/{b} ={m * b}/{n * a}= {imp}");
        }
        static void comparati(int m, int n, int a, int b)
        {
            if (m / n < a / b)
            {
                Console.WriteLine($"{m}/{n} < {a}/{b}");
            }
            if (m / n > a / b)
            {
                Console.WriteLine($"{m}/{n} > {a}/{b}");
            }
            if (m / n == a / b)
            {
                Console.WriteLine($"{m}/{n} = {a}/{b}");
            }
            if (m / n != a / b)
            {
                Console.WriteLine($"{m}/{n} != {a}/{b}");
            }
        }
        static void putere(int n, int m, int p)
        {
            double patrat = (Math.Pow(m, p)) / (Math.Pow(n, p));
            Console.WriteLine($"({m}/{n})^{p} ={Math.Pow(m, p)}/{Math.Pow(n, p)}= {patrat}");
        }
        static int cmmdc(int a, int b)
        {
            int cmmdc = 0;
            if (a > b)
            {
                cmmdc = a;
            }
            else cmmdc = b;
            while ((a % cmmdc != 0) || (b % cmmdc != 0))
            {
                cmmdc--;
            }
            return cmmdc;
        }
        static int cmmmc(int a, int b)
        {
            int cmmmc = 0;
            if (a > b) cmmmc = a;
            else cmmmc = b;
            while ((a % cmmmc != 0) || (b % cmmmc != 0))
            {
                cmmmc++;
            }
            return cmmmc;

        }

        static void ireductibil(int m, int n, int a, int b)
        {
            double adunare = 0;
            if (m % n == 0 && a % b != 0)
            {
                adunare = (((m / n) * b) + a) / b;

            }
            if (m % n == 0 && a % b == 0)
            {
                adunare = m / n + a / b;
            }
            if (m % n != 0 && a % b == 0)
            {
                adunare = (((a / b) * n) + m) / n;
            }
            if (m % n != 0 && a % b != 0)
            {

                adunare = (m * (cmmmc(n, b) / n) + a * (cmmmc(b, n) / b)) / cmmmc(n, b);

            }
            Console.WriteLine(adunare);

        }
        static void simplificare(int m, int n)
        {
            int simple = cmmdc(m, n);
            if (simple != 1)
            {
                Console.WriteLine($"Fractia {m}/{n} se simplifica cu: {cmmdc(m, n)} si devine {m}/{n}={m / simple}/{n / simple}");
            }
            else Console.WriteLine("fractia este ireductibila");
        }
    }
    
}
