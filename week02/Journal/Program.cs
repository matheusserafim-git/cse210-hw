using System;

// i add a final message when you finish and saving the jornal


class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        RandomGenerator randomGenerator = new RandomGenerator();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string Choice = Console.ReadLine();
            Console.WriteLine();

            if (Choice == "1")
            {
                string prompt = randomGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string entryText = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString();
                entry._promptText = prompt;
                entry._entryText = entryText;

                journal.AddEntry(entry);
            }

            else if (Choice == "2")
            {
                journal.DisplayAll();
            }
            else if (Choice == "3")
            {
                Console.Write("Enter the filename to save to: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (Choice == "4")
            {
                Console.Write("Enter the filename to load from: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                journal.DisplayAll();
            }
            else if (Choice == "5")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }

            Console.WriteLine();
        }

    }
}