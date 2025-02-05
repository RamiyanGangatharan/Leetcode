namespace Leetcode.Part_1._1_Arrays_Hashing
{
    internal class ValidAnagram
    {
        /// <summary>
        /// Determines whether two input strings are anagrams.
        /// An anagram is a word or phrase formed by rearranging the letters of another.
        /// This method returns true if the two strings contain the same characters in the same frequency.
        /// </summary>
        /// <param name="s">The first string.</param>
        /// <param name="t">The second string.</param>
        /// <returns>True if t is an anagram of s, otherwise false.</returns>
        /// <remarks>
        /// Time Complexity: O(n log n) due to sorting both strings.
        /// Space Complexity: O(n) because of the character arrays created from the input strings.
        /// </remarks>
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            char[] sArr = s.ToLower().ToCharArray();
            char[] tArr = t.ToLower().ToCharArray();

            Array.Sort(sArr);
            Array.Sort(tArr);


            // return a bool value depending on if the strings equal eachother after conversion
            bool result = new string(sArr) == new string(tArr);

            Console.WriteLine($"{s} {(result ? "is" : "is not")} an anagram of {t}");
            return result;
        }
    }
}
