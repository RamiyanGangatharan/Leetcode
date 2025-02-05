namespace Leetcode.Part_1._1_Arrays_Hashing
{
    internal class ContainsDuplicates
    {
        /// <summary>
        /// Determines whether an integer array contains any duplicate values.
        /// 
        /// This function iterates through the array while storing elements in a HashSet.
        /// If a number has already been seen, it returns true immediately.
        /// Otherwise, it adds the number to the set and continues.
        /// 
        /// Time Complexity: O(N) → Linear, as each element is processed once.
        /// Space Complexity: O(N) → Additional storage for unique elements.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <returns>True if a duplicate exists, otherwise false.</returns>
        public bool RunContainsDuplicate(int[] nums)
        {
            Console.Clear();
            Console.WriteLine("Contains Duplicate Problem");
            Console.WriteLine("==========================");

            Console.Write("Dataset: ");
            for (int i = 0; i < nums.Length; i++) { Console.Write(nums[i]); }

            Console.WriteLine();

            HashSet<int> seen = new HashSet<int>();
            foreach (int number in nums)
            {
                if (seen.Contains(number))
                {
                    Console.WriteLine("There is a duplicate! " + "it is " + number);
                    return true;
                }
                seen.Add(number);
            }
            Console.WriteLine("There are no duplicate values!");
            return false;
        }
    }
}
