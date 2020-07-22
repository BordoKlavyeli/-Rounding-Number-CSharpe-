using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi; int a; double yuvarlama; double sayitanim;
            Console.WriteLine("sayı: ");
            sayi = Convert.ToDouble(Console.ReadLine());
            sayitanim = sayi;//sonra global
            double ondalik = sayi;//sonra
            double sonhal;

            if (sayi > 0)
            {
                for (a = 0; a <= (int)sayi; a++)
                {
                    ondalik -= 1;
                    if (ondalik < 1)
                    {
                        break;
                    }

                }
                yuvarlama = 1 - ondalik;
                if (ondalik >= 0.5)
                {
                    sonhal = sayitanim + yuvarlama;
                }
                else
                {
                    sonhal = (int)sayitanim;
                }
                Console.WriteLine("Yuvarlanmis Hali: " + sonhal);
            }
            else if (sayi < 0)
            {
                for (a = 0; a >= (int)sayi; a--)
                {
                    ondalik += 1;
                    //Console.WriteLine(ondalik);
                    if (ondalik > -1)
                    {
                        break;
                    }
                }
                yuvarlama = ondalik + 1;
                yuvarlama = yuvarlama * -1;

                if (ondalik > -0.5)
                {
                    sonhal = (int)sayitanim;
                    Console.WriteLine("Yuvarlanmis Hali: " + sonhal);
                }
                else if (ondalik <= -0.5)
                {
                    sonhal = (int)sayitanim - 1;
                    Console.WriteLine("Yuvarlanmis Hali: " + sonhal);
                }
            }
            Console.ReadKey();
        }
    }
}
