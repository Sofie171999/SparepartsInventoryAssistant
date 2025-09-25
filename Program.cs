// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lagerets dele
        List<string> inventory = new List<string>
        {
            "hydraulic pump",
            "PLC module",
            "servo motor"
        };

        Console.WriteLine("Hej. Welcome to the spare parts inventory!");
        Console.WriteLine("Which part do you need?");

        while (true)
        {
            string input = Console.ReadLine();

            // Tjek for specialspørgsmål
            if (input.Equals("Do you actually have any parts?", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("Is there anything in stock at all?", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"We have {inventory.Count} part(s)!");
                foreach (string part in inventory)
                {
                    Console.WriteLine(part);
                }
                continue; // fortsæt dialogen
            }

            // Tjek om input matcher en reservedel præcist
            if (inventory.Contains(input))
            {
                Console.WriteLine($"I have got {input} here for you 😊. Bye!");
                break; // afslut programmet
            }
            else
            {
                Console.WriteLine($"I am afraid we don’t have any {input} in the inventory 😔");
            }
        }
    }
}
