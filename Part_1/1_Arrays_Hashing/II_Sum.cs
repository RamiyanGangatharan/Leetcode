namespace Leetcode.Part_1._1_Arrays_Hashing
{
    internal class II_Sum
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. 
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Console.Write("Array: ");
            for (int i = 0; i < nums.Length; i++) { Console.Write(nums[i] + ", "); }

            Console.Write($"\nTarget: {target} \n\n");

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.Write($"{nums[i]} + {nums[j]}" + $" = {target}");
                        return [i, j];
                    }
                }
            }
            return Array.Empty<int>();
        }
    }
}
