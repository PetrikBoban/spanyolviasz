using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamonkeres
{
    internal class Program
    {
        

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            int osszeg = 0;

            for (int i = 0; i < 1000000; i++)
            {
                string szam = i.ToString();

                if (szam == Reverse(szam))
                {
                    string joszambin = Convert.ToString(i, 2);

                    if (joszambin == Reverse(joszambin))
                    {
                        osszeg += i;
                    }
                }
            }

            Console.WriteLine(osszeg);
        }
    }
}
