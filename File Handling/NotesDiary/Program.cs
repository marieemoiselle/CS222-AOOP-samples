using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static string filePath = "notes.txt";

    static void Main()
    {
        EnsureFileExists();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Notes Diary");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. View all entries");
            Console.WriteLine("3. Modify an entry");
            Console.WriteLine("4. Delete an entry");
            Console.WriteLine("5. Insert entry in between");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;
                case "2":
                    ViewEntries();
                    break;
                case "3":
                    ModifyEntry();
                    break;
                case "4":
                    DeleteEntry();
                    break;
                case "5":
                    InsertEntry();
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    Pause();
                    break;
            }
        }
    }

    static void EnsureFileExists()
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }
    }

    static void AddEntry()
    {
        Console.Write("Enter your note (press x to cancel): ");
        string? input = Console.ReadLine();
        if (input?.ToLower() == "x") return;

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        File.AppendAllText(filePath, $"{timestamp}{Environment.NewLine}{input ?? string.Empty}{Environment.NewLine}");
        Console.WriteLine("Entry added.");
        Pause();
    }

    static void ViewEntries()
    {
        List<string> lines = File.ReadAllLines(filePath).ToList();

        if (lines.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        int index = 1;
        for (int i = 0; i < lines.Count; i += 2)
        {
            if (i + 1 < lines.Count)
            {
                Console.WriteLine($"[{index}]  {lines[i]}"); // timestamp
                Console.WriteLine(lines[i + 1] ?? string.Empty); // entry text (default to empty if null)
                Console.WriteLine(); // empty line between entries
                index++;
            }
        }
    }

    static void ModifyEntry()
    {
        List<string> lines = File.ReadAllLines(filePath).ToList();

        if (lines.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        // Display all entries for selection
        ViewEntries();

        Console.Write("Enter the index of the entry to modify: ");
        string input = Console.ReadLine() ?? string.Empty; // Default to empty string if null

        // If 'X' or 'x' is pressed, exit modification
        if (input.ToLower() == "x")
        {
            return;
        }

        if (int.TryParse(input, out int index) && index >= 1 && index <= lines.Count / 2)
        {
            int lineIndex = (index - 1) * 2; // Multiply by 2 because each entry has 2 lines (timestamp + content)

            // Modify the timestamp (first line of the entry)
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lines[lineIndex] = timestamp;

            // Modify the entry text (second line of the entry)
            Console.Write("Enter the new text for the entry: ");
            string newText = Console.ReadLine() ?? string.Empty; // Default to empty string if null

            // Replace the second line with the new text
            lines[lineIndex + 1] = newText;

            // Write the modified entries back to the file
            File.WriteAllLines(filePath, lines);

            Console.WriteLine("Entry modified successfully.");
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
    }

    static void DeleteEntry()
    {
        List<string> lines = File.ReadAllLines(filePath).ToList();

        if (lines.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        // Display all entries for selection
        ViewEntries();

        Console.Write("Enter the index of the entry to delete: ");
        string input = Console.ReadLine() ?? string.Empty; // Default to empty string if null

        // If 'X' or 'x' is pressed, exit deletion
        if (input.ToLower() == "x")
        {
            return;
        }

        if (int.TryParse(input, out int index) && index >= 1 && index <= lines.Count / 2)
        {
            int lineIndex = (index - 1) * 2; // Multiply by 2 because each entry has 2 lines (timestamp + content)

            // Remove both the timestamp and the entry text
            lines.RemoveAt(lineIndex);      // Remove timestamp
            lines.RemoveAt(lineIndex);      // Remove entry text (same index because we removed the timestamp first)
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Entry deleted successfully.");
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
    }

    static void InsertEntry()
    {
        string[] lines = File.ReadAllLines(filePath);

        ViewEntries();
        Console.Write("Enter index to insert entry (x to cancel): ");
        string? input = Console.ReadLine();
        if (input?.ToLower() == "x") return;

        if (int.TryParse(input, out int index) && index >= 0 && index <= lines.Length)
        {
            Console.Write("Enter the entry: ");
            string? newEntry = Console.ReadLine();
            if (newEntry?.ToLower() == "x") return;

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            List<string> updated = new List<string>(lines);
            updated.Insert(index * 2, timestamp);
            updated.Insert(index * 2 + 1, newEntry ?? string.Empty); // Ensure no null values are inserted
            File.WriteAllLines(filePath, updated);
            Console.WriteLine("Entry inserted.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
