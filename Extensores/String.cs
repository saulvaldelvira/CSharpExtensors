namespace Extensores {
    public static class String {
        /// <summary>
        /// Returns the number of vocals in a string
        /// </summary>
        /// <param name="str">the string</param>
        /// <returns>the number of vocals (int)</returns>
        public static int NumberOfVocals(this string str) {
            int result = 0;
            foreach (char c in str)
                if ("aeiouáéíóú".Contains(c))
                    result++;
            return result;
        }
        /// <summary>
        /// Given a character, counts the number of times it appears in the string
        /// </summary>
        /// <param name="str">the string</param>
        /// <param name="ch">the character to count</param>
        /// <returns>the number of times the char appears (int)</returns>
        public static int CountCharacter(this string str, char ch) {
            int result = 0;
            foreach (char c in str)
                if (ch == c)
                    result++;
            return result;
        }
    }
}
