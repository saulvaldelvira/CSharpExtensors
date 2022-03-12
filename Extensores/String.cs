namespace Extensores {
    public static class String {
        public static int NumeroVocales(this string str) {
            int result = 0;
            foreach (char c in str)
                if ("aeiouáéíóú".Contains(c))
                    result++;
            return result;
        }

        public static int CuentaCaracter(this string str, char ch) {
            int result = 0;
            foreach (char c in str)
                if (ch == c)
                    result++;
            return result;
        }
    }
}
