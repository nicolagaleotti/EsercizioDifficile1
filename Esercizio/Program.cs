using System;
using System.IO;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                string filein = "input.txt";
                string fileout = "output.txt";
                string numeri = " ";
                string lunghezza = "";
                int n;
                int x;
                int i = 0;
                char stop;
                int c;
                string numero ="";

                if (File.Exists(filein))
                {
                    using (StreamReader reader = new StreamReader(filein))
                    {
                        numeri = reader.ReadLine();
                    }
                }

                do
                {
                    stop = numeri[i];
                    i = i + 1;
                } while (stop != '1');

                for (c = i; c < i + i - 1; c++)
                {
                    lunghezza += int.Parse(numeri[c].ToString());
                }
                Console.WriteLine(lunghezza);

                n = int.Parse(lunghezza); 

                for (int j = c; j < c + n; j++)
                {
                    numero += numeri[j].ToString();
                }

                x = int.Parse(numero);

                Console.WriteLine(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
