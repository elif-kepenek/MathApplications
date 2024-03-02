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
    }
}