using Leetcode;

internal class Program
{
    /// <summary>
    /// Main menu of the program
    /// </summary>
    private static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n=====================================================");
            Console.WriteLine("|                 LEETCODE MENU                     |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("| 1. Arrays & Hashing                               |");
            Console.WriteLine("| 0. Exit                                           |");
            Console.WriteLine("=====================================================");
            Console.Write("[_Select an option_]: ");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1": ArraysMenu(); break;
                case "0": Console.WriteLine("\nExiting program..."); return;
                default:  Console.WriteLine("\nInvalid choice! Please enter a valid option."); break;
            }

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Menu for the Arrays & Hashing Section
    /// </summary>
    private static void ArraysMenu()
    {
        ArraysAndHashing arrays = new();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("|             ARRAYS & HASHING MENU                 |");
            Console.WriteLine("=====================================================");
            Console.WriteLine("| 1. Contains Duplicates                            |");
            Console.WriteLine("| 2. Valid Anagram                                  |");
            Console.WriteLine("| 3. Two Sum                                        |");
            Console.WriteLine("| 4. Group Anagram                                  |");
            Console.WriteLine("| 5. Top K Frequent Elements                        |");
            Console.WriteLine("| 0. Back to Main Menu                              |");
            Console.WriteLine("=====================================================");
            Console.Write("[_Select an option_]: ");

            string? input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    int[] nums = { 1, 2, 3, 4, 2 };
                    Console.Clear();
                    Console.WriteLine("Contains Duplicate Problem");
                    Console.WriteLine("==========================");
                    Console.WriteLine("Dataset: " + string.Join(", ", nums) + "\n");
                    arrays.ContainsDuplicate(nums);
                    break;
                case "2":
                    string s = "rat", t = "car";
                    Console.Clear();
                    Console.WriteLine("Valid Anagram Problem");
                    Console.WriteLine("=====================");
                    Console.WriteLine($"Words: \"{s}\" and \"{t}\"\n");
                    arrays.IsAnagram(s, t);
                    break;
                case "3":
                    int[] twoSumArray = { 2, 7, 11, 15 };
                    int target = 9;
                    Console.Clear();
                    Console.WriteLine("Two Sum Problem");
                    Console.WriteLine("===============");
                    Console.WriteLine("Dataset: " + string.Join(", ", twoSumArray));
                    Console.WriteLine("Target: " + target + "\n");
                    arrays.TwoSum(twoSumArray, target);
                    break;
                case "4":
                    string[] anagrams = { "eat", "tea", "tan", "ate", "nat", "bat" };
                    Console.Clear();
                    Console.WriteLine("Group Anagrams Problem");
                    Console.WriteLine("======================");
                    Console.WriteLine("Dataset: " + string.Join(", ", anagrams) + "\n");
                    arrays.GroupAnagrams(anagrams);
                    break;
                case "5":
                    int[] numbers = { 1, 2, 3, 1, 2, 1 };
                    int k = 2;
                    Console.Clear();
                    Console.WriteLine("Top K Frequent Elements Problem");
                    Console.WriteLine("===============================");
                    Console.WriteLine("Dataset: " + string.Join(", ", numbers));
                    Console.WriteLine("K: " + k + "\n");
                    arrays.TopKFrequent(numbers, k);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("\nInvalid choice! Please enter a valid option.");
                    break;
            }

            Console.WriteLine("\nPress any key to return to the Arrays & Hashing menu...");
            Console.ReadKey();
        }
    }
}
