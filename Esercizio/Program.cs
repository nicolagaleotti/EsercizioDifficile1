using System;
using System.IO;

namespace Esercizio
{
    class Program
    {
        static void Main(string[] args)
        {
            string filein = "input.txt";
            string fileout = "output.txt";
            string numeri;
            if (File.Exists(filein))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filein))
                    {
                        numeri = reader.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
