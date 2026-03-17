using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>();
        string input;
        string filePath = "names.txt";

        // Step 1: Input Loop
        while (true)
        {
            Console.Write("Enter a name: ");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input)) continue;
            if (input.Trim().ToLower() == "exit") break;

            names.Add(input.Trim());
        }

        // Step 2: Save to logic
        try
        {
            File.WriteAllLines(filePath, names);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving names: {ex.Message}");
            return;
        }

        // Step 3: Read and Display logic
        Console.WriteLine("\nThese are the names:");
        try
        {
            if (File.Exists(filePath))
            {
                string[] savedNames = File.ReadAllLines(filePath);
                foreach (string name in savedNames)
                {
                    Console.WriteLine(name);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading names: {ex.Message}");
        }
    }
}
