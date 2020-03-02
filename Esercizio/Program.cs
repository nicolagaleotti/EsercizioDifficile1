using System;
using System.IO;
using System.Numerics;

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
                int n;
                BigInteger x = new BigInteger();
                int i = 0;
                char stop;
                int c = 0;
                int j = 0;
                int d = 0;
                string numero ="";

                if (File.Exists(filein))
                {
                    using (StreamReader reader = new StreamReader(filein))
                    {
                        numeri = reader.ReadLine();
                    }
                }

                using (StreamWriter writer = new StreamWriter(fileout))

                do
                {
                    string lunghezza = "";
                    i = j;
                    d = 0;
                    numero = "";
                    do
                    {
                        stop = numeri[i];
                        i++;
                        d++;
                    } while (stop != '1');

                    for (c = i; c < i + d - 1; c++)
                    {
                        lunghezza += int.Parse(numeri[c].ToString());
                    }

                    n = int.Parse(lunghezza);

                    for (j = c; j < c + n; j++)
                    {
                        numero += numeri[j].ToString();
                    }

                    x = BigInteger.Parse(numero);

                    Console.WriteLine(x);

                    writer.WriteLine(x);

                } while (numeri[j] != '*');

                Console.WriteLine($"Salvati sul file {fileout}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
