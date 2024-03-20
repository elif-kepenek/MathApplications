namespace MathAplications
{
    public class Number
    {

        /// <summary>
        /// Parametre olarak aldığı sayının tek olup olmamasını kontrol eder.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Tek ise true değilse false</returns>
        public static bool OddNumber (int n)
        {
            if (n % 2 == 1)
            {
                return true;
            } else {
                return false;
            }
        }

        /// <summary>
        /// Parametre olarak aldığı sayının çift olup olmamasını kontrol eder.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Çift ise true değilse false</returns>
        public static bool EvenNumber (int n)
        {
            if (n % 2 == 0)
            {
                return true;
            } else {
                return false;
            }
        }
    
        /// <summary>
        /// Parametre olarak aldığı sayının mutlak değerini döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Mutlak değer</returns>
        public static int AbsoluteValue (int n) {
            if (n > 0)
            {
                return n;
            } else if (n < 0)
            {
                return n * (-1);                
            } else {
                return 0;
            }
        }

        /// <summary>
        /// Parametre olarak aldığı sayının asal sayı olup olmamasını kontrol eder.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Asal sayı</returns>
        public static bool PrimeNumber (int n) {
            if (n <= 1)
            {
                Console.WriteLine("En küçük asal sayı 2'dir.");
                return false;
            }

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Parametre olarak aldığı sayının rakamları toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Rakamlar toplamı</returns>
        public static int SumOfDigits (int n) {
            int total = 0;
            int digit = 0;

            while (n > 0)
            {
                digit = n % 10;
                total += digit;
                n = n / 10;
            }
            return total;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan sayıların toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Sayılar toplamı</returns>
        public static int SumOfNumbersUpTo_n (int n) {
            int t = 0;
            for (int i = 1; i <= n; i++)
                t += i;
            return t;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan sayıların formül ile toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Sayılar toplamı</returns>
        public static int FormulaSumOfNumbersUpTo_n (int n) {
            return n * (n + 1) / 2;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan tek sayıların toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Tek sayıların toplamı</returns>
        public static int SumOfOddNumbersUpTo_n (int n) {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    t += i;
                }
            }
            return t;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan tek sayıların toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Tek sayıların toplamı</returns>
        public static int SumOfOddNumbersUpTo_n1 (int n) {
            int t = 0;
            for (int i = 1; i <= n; i += 2)
            {
                t += i;
            }
            return t;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan tek sayıların formül ile toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Tek sayıların toplamı</returns>
        public static int FormulaForSumOfOddNumbersUpTo_n (int n) {
            n += 1;
            n = n / 2;
            return n * n;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan çift sayıların toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Çift sayıların toplamı</returns>
        public static int SumOfEvenNumbersUpTo_n (int n) {
            int t = 0;
            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    t += i;
                }
            }
            return t;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan çift sayıların toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Çift sayıların toplamı</returns>
        public static int SumOfEvenNumbersUpTo_n1 (int n) {
            int t = 0;
            for (int i = 2; i <= n; i += 2)
            {
                t += i;
            }
            return t;
        }

        /// <summary>
        /// Parametre olarak girilen sayıya kadar olan çift sayıların formül ile toplamını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Çift sayıların toplamı</returns>
        public static int FormulaForSumOfEvenNumbersUpTo_n (int n) {
            n = n / 2;
            return n * (n + 1);
        }

        /// <summary>
        /// Parametre olarak aldığı sayıların üslü ifadesini döner.
        /// </summary>
        /// <param name="a">Taban</param>
        /// <param name="exponent">Üs</param>
        /// <returns>Üslü sayı</returns>
        public static double Exponentiation (double a, double exponent) {
            double result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}