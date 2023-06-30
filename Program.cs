// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide file paths as command line arguments.");
            return;
        }

        HashSet<string> uniqueLines = new HashSet<string>();

        foreach (string filePath in args)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        uniqueLines.Add(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading file {filePath}: {e.Message}");
            }
        }

        Console.WriteLine("Unique lines:");

        foreach (string line in uniqueLines)
        {
            Console.WriteLine(line);
        }
    }
}
