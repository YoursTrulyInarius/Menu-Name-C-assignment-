    using System;
    using System.IO;

    string filePath = "items.txt";
    string? choice = "";

    while (choice != "3")
    {
        Console.Clear();
        Console.WriteLine("Menu");
        Console.WriteLine("[1] Add item");
        Console.WriteLine("[2] View items");
        Console.WriteLine("[3] Exit");
        Console.Write("What do you want to do? ");
        choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Enter item name: ");
            string? itemName = Console.ReadLine();
            if (!string.IsNullOrEmpty(itemName))
            {
                File.AppendAllLines(filePath, new[] { itemName });
                Console.WriteLine("Item save successfully. . .");
                Console.WriteLine("\nPress any key to return to menu...");
                Console.ReadKey();
            }
        }
        else if (choice == "2")
        {
            Console.WriteLine("\nThere are the items :");
            if (File.Exists(filePath))
            {
                string[] items = File.ReadAllLines(filePath);
                foreach (string item in items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("(No items found)");
            }
            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
        }
        else if (choice == "3")
        {
            Console.WriteLine("thank You for using");
        }
        else if (!string.IsNullOrEmpty(choice))
        {
            Console.WriteLine("Invalid choice. Press any key to try again.");
            Console.ReadKey();
        }
    }
