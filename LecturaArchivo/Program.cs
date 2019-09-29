using System;
using System.Collections.Generic;
using System.IO;

namespace LecturaArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = ReadFrom("/Users/kernel_panic/sampleQuotes.txt");

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }


        static IEnumerable<string> ReadFrom(string file) {
            string line;

            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

    }
}


//yield: nos permite acceder a elementos de una lista IEnumerable de forma progesiva