class Program
{
    /// <summary>
    /// Main menu of the program
    /// </summary>
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Leetcode Practice Menu");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Arrays & Hashing");
            Console.WriteLine("0. Exit");
            Console.Write("Select a Directory: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": ArraysMenu(); break;
                case "0": Console.WriteLine("Exiting program..."); return;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Menu for the Arrays & Hashing Section
    /// </summary>
    static void ArraysMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Arrays & Hashing");
            Console.WriteLine("================");
            Console.WriteLine("1. Contains Duplicates");
            Console.WriteLine("0. Back to Main Menu");
            Console.Write("Select a Program: ");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1": RunContainsDuplicate(); break;
                case "0": return;
                default: Console.WriteLine("Invalid choice, try again."); break;
            }

            Console.WriteLine("\nPress any key to return to the Arrays menu...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Display method for the Contains Duplicate problem
    /// </summary>
    static void RunContainsDuplicate()
    {
        Console.Clear();
        Console.WriteLine("Contains Duplicate Problem");
        Console.WriteLine("==========================");
        Console.WriteLine("----------- WIP ----------\n");
    }
}
