using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPrinciples
{
    public class RegulaDataFile : IFileReader
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    

            string regularData = @"C:\Users\Radhika\source\repos\DesignPrinciples\RegularData.txt";
            string[] lines = File.ReadAllLines(regularData);
            Console.WriteLine("\nData Successfully read from RegularData\n");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
