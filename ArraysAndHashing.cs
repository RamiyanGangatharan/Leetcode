namespace Leetcode
{
    internal class ArraysAndHashing
    {
        /// <summary>
        /// Determines whether an integer array contains any duplicate values.
        /// Uses a HashSet to track seen elements.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <returns>True if a duplicate exists, otherwise false.</returns>
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = [];

            foreach (int number in nums)
            {
                if (!seen.Add(number))
                {
                    Console.WriteLine($"There is a duplicate! It is {number}");
                    return true;
                }
            }
            Console.WriteLine("There are no duplicate values!");
            return false;
        }

        /// <summary>
        /// Determines whether two input strings are anagrams.
        /// </summary>
        /// <param name="s">The first string.</param>
        /// <param name="t">The second string.</param>
        /// <returns>True if t is an anagram of s, otherwise false.</returns>
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) { return false; }

            char[] sArr = s.ToLower().ToCharArray();
            char[] tArr = t.ToLower().ToCharArray();

            Array.Sort(sArr);
            Array.Sort(tArr);

            bool result = new string(sArr) == new string(tArr);
            Console.WriteLine($"{s} {(result ? "is" : "is not")} an anagram of {t}");
            return result;
        }

        /// <summary>
        /// Finds two numbers in the array that sum up to the target.
        /// Returns their indices.
        /// </summary>
        /// <param name="nums">Array of integers.</param>
        /// <param name="target">Target sum.</param>
        /// <returns>Array with the indices of the two numbers.</returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndex = [];

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numIndex.ContainsKey(complement))
                {
                    Console.WriteLine($"{nums[i]} + {nums[numIndex[complement]]} = {target}");
                    return new int[] { numIndex[complement], i };
                }
                numIndex[nums[i]] = i;
            }

            return Array.Empty<int>();
        }

        /// <summary>
        /// Groups anagrams from a given array of strings.
        /// </summary>
        /// <param name="strs">Array of input strings.</param>
        /// <returns>List of grouped anagrams.</returns>
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> anagramGroups = [];

            foreach (string str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string sortedStr = new(charArray);

                if (!anagramGroups.ContainsKey(sortedStr)) { anagramGroups[sortedStr] = []; }
                anagramGroups[sortedStr].Add(str);
            }

            string output = string.Join(",", anagramGroups.Values.Select(group => $"[{string.Join(",", group.Select(s => $"\"{s}\""))}]"));
            Console.WriteLine($"[{output}]");

            return new List<IList<string>>(anagramGroups.Values);
        }



        /// <summary>
        /// Finds the k most frequent elements in an array.
        /// (Currently not implemented)
        /// </summary>
        /// <param name="nums">Array of integers.</param>
        /// <param name="k">Number of top frequent elements to find.</param>
        public void TopKFrequent(int[] nums, int k)
        {
            // TODO: Implement this function.
        }
    }
}
