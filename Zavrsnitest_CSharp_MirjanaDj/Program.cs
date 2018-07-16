using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zavrsnitest_CSharp_MirjanaDj
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1.deo

            /* definisanje promenljivih ukljucuje tip promenjive i samu promenljivu
            npr. int a;
            double b; 
            string c; */


            /* inicijalizacija promenljivih - definisanoj promenljivoj se dodeljuje konkretna vrednost
             npr. int a = 5;
             double b = 23,145;
             string c = "asdf";
             */

            // 2.deo

            Console.Write("Drugi deo:" + Environment.NewLine);

            Console.WriteLine("Unesite vrednost promenljive a:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite vrednost promenljive b:");
            int b = Convert.ToInt32(Console.ReadLine());

            int rez = a + b;

            if (a != b)
            {
                Console.WriteLine("Suma broja {0} i broja {1} iznosi {2}.", a, b, rez);
            }
            else
            {
                int rez1 = rez * 3;
                Console.WriteLine("Suma broja {0} i broja {1} pomnozena sa 3 iznosi {2}.", a, b, rez1);
                Console.WriteLine("" + Environment.NewLine);
            }

            

            // 3.deo
            Console.Write("Treci deo:" + Environment.NewLine);

            Console.WriteLine("Unesite vrednost promenljive x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite vrednost promenljive y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite vrednost promenljive z:");
            int z = Convert.ToInt32(Console.ReadLine());

            Program n = new Program();
            int resultmax = n.FindMax(x, y, z);

            Console.WriteLine("Maksimalna vrednost od tri uneta broja je: {0}", resultmax);


            Program m = new Program();
            int resultmin = m.FindMin(x, y, z);

            Console.WriteLine("Minimalna vrednost od tri uneta broja je: {0}", resultmin);

            Console.ReadKey();


        }

        public int FindMax(int num1, int num2, int num3)
        {
            int max = 0;
            if (num1 >= num2 && num1 >= num3)
                max = num1;
            else
                if (num2 > num1 && num2 >= num3)
                max = num2;
            else
                if (num3 > num1 && num3 > num2)
                max = num3;

            return max;
        }

        public int FindMin(int num1, int num2, int num3)
        {
            int min = 0;
            if (num1 <= num2 && num1 <= num3)
                min = num1;
            else
                if (num2 < num1 && num2 <= num3)
                min = num2;
            else
                if (num3 < num1 && num3 < num2)
                min = num3;

            return min;
        }





    }
}
