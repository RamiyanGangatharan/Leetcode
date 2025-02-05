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
            HashSet<int> seen = new HashSet<int>();

            Console.Clear();
            Console.WriteLine("Contains Duplicate Problem");
            Console.WriteLine("==========================");
            Console.Write("Dataset: " + string.Join(", ", nums) + "\n\n");

            
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
    }
}
