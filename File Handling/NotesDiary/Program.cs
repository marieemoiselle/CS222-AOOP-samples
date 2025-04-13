using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static string filePath = "notes.txt";

    static void Main()
    {
        EnsureFileExists();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- NOTES DIARY ---");
            Console.WriteLine("1. Add an entry");
            Console.WriteLine("2. View all entries");
            Console.WriteLine("3. Modify an entry");
            Console.WriteLine("4. Delete an entry");
            Console.WriteLine("5. Insert entry");
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
                    ExitDiary();
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
        File.AppendAllText(filePath, $"{timestamp} | {input}{Environment.NewLine}");
        Console.WriteLine("Entry added.");
        Pause();
    }

    static void ViewEntries()
    {
        EnsureFileExists();
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length == 0)
        {
            Console.WriteLine("No entries yet.");
        }
        else
        {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }
        }
        Pause();
    }

    static void ModifyEntry()
    {
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length == 0)
        {
            Console.WriteLine("No entries to modify.");
            Pause();
            return;
        }

        ViewEntries();
        Console.Write("Enter entry number to modify (x to cancel): ");
        string? input = Console.ReadLine();
        if (input?.ToLower() == "x") return;

        if (int.TryParse(input, out int index) && index > 0 && index <= lines.Length)
        {
            Console.Write("Enter new text: ");
            string? newText = Console.ReadLine();
            if (newText?.ToLower() == "x") return;

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            lines[index - 1] = $"{timestamp} | {newText}";
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Entry updated.");
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
        Pause();
    }

    static void DeleteEntry()
    {
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length == 0)
        {
            Console.WriteLine("No entries to delete.");
            Pause();
            return;
        }

        ViewEntries();
        Console.Write("Enter entry number to delete (x to cancel): ");
        string? input = Console.ReadLine();
        if (input?.ToLower() == "x") return;

        if (int.TryParse(input, out int index) && index > 0 && index <= lines.Length)
        {
            List<string> updatedLines = new List<string>(lines);
            updatedLines.RemoveAt(index - 1);
            File.WriteAllLines(filePath, updatedLines);
            Console.WriteLine("Entry deleted.");
        }
        else
        {
            Console.WriteLine("Invalid entry number.");
        }
        Pause();
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
            updated.Insert(index, $"{timestamp} | {newEntry}");
            File.WriteAllLines(filePath, updated);
            Console.WriteLine("Entry inserted.");
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
        Pause();
    }

    static void ExitDiary()
    {
        Console.WriteLine("This has been your diary! :)");
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}