namespace Extensores {
    public static class Integer {
        public static bool IsPrime(this int n) {
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        public static int NextPrime(this int n) {
            while (!(++n).IsPrime());
            return n;
        }

        public static int PreviousPrime(this int n) {
            while (!(--n).IsPrime());
            return n;
        }
    }
}
