namespace Extensores {
    public static class Integer {
        /// <summary>
        /// Returns true if the number is prime, false if it is not.
        /// It is important to notice that the number 1 returns false 
        /// when calling this method, because i am taking the definition of
        /// a prime number as: "A number greater that one that it it only
        /// divisible by itself and 1"
        /// <url>https://en.wikipedia.org/wiki/Prime_number</url>
        /// </summary>
        /// <param name="n">The number</param>
        /// <returns>true if prime, false if not</returns>
        public static bool IsPrime(this int n) {
            //The for loop starts in 2 and goes til i<n, so if n is two it would jump off and 
            //return true even if two is not prime. So 1 and 2 return false with this condition.
            if (n == 1 || n == 2) return false;
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        /// <summary>
        /// Return the next prime number to the one who calls the function
        /// </summary>
        /// <param name="n">the number whose next int is wanted</param>
        /// <returns>the next prime number (int)</returns>
        public static int NextPrime(this int n) {
            while (!(++n).IsPrime());
            return n;
        }
        /// <summary>
        /// Return the previous prime number to the one who calls the function
        /// </summary>
        /// <param name="n">the number whose previous int is wanted</param>
        /// <returns>the previous prime number (int)</returns>
        public static int PreviousPrime(this int n) {
            while (!(--n).IsPrime());
            return n;
        }
    }
}
