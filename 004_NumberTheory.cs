namespace MathAplications
{
    public class NumberTheory
    {
        /// <summary>
        /// Parametre olarak girilen sayının asal çarpnlarını döner.
        /// </summary>
        /// <param name="n">Sayı</param>
        /// <returns>Asal çarpanlar</returns>
        public static int[] PrimeFactorization (int n) {
            string multiplierList = "";
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    multiplierList += i.ToString() + ",";
                } else
                {
                    i++;
                }
            }

            multiplierList = multiplierList.Substring(0, multiplierList.Length - 1);
            string[] multiplier = multiplierList.Split(",");

            // tekrar eden sayıları bir defa yazabilmek için
            string s = multiplier[0];
            string y = s;

            for (i = 0; i < multiplier.Length; i++)
            {
                if (!(s == multiplier[i]))
                {
                    y = y + "," + multiplier[i];
                    s = multiplier[i];
                }
            }

            multiplier = y.Split(",");
            int[] primeFactorization = new int[multiplier.Length];

            for (i = 0; i < primeFactorization.Length; i++)
            {
                primeFactorization[i] = Convert.ToInt32(multiplier[i]);
            }

            return primeFactorization;
        }

        public static int SumOfPrimeFactors (int n) {
            int[] primeFactorization = PrimeFactorization(n);
            int total = 0;

            for (int i = 0; i < primeFactorization.Length; i++)
            {
                total += primeFactorization[i];
            }            
            
            return total;
        }

        public static int MultiplicationOfPrimeFactors (int n) {
            int[] primeFactorization = PrimeFactorization(n);
            int multiplication = 1;

            for (int i = 0; i < primeFactorization.Length; i++)
            {
                multiplication *= primeFactorization[i];
            }
            return multiplication;
        }

        /// <summary>
        /// Ortak katların en küçüğünü hesaplar.
        /// </summary>
        /// <param name="s1">Sayı 1</param>
        /// <param name="s2">Sayı 2</param>
        /// <returns>OKEK</returns>
        public static int LeastCommonMultiple (int s1, int s2) {
            
            // TO DO : eksikler giderilecek
            
            int result = 1;
            if (s1 == s2 + 1 || s2 == s1 + 1)
            {
                result = s1 * s2;
            } else {

                while (s1 != 1 && s2 != 1)
                {
                    int divide = 2;

                    for (int i = 1; i <= (s1 > s2 ? s1 : s2); i++)
                    {
                        if (s1 % divide == 0 || s2 % divide == 0)
                        {
                            result *= divide;
                            if (s1 % divide == 0)
                            {
                                s1 = s1 / divide;
                            }
                            if (s2 % divide == 0)
                            {
                                s2 = s2 / divide;
                            }
                        } else {
                        divide++;
                        }
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Ortak bölenlerin en büyüğünü hesaplar.
        /// </summary>
        /// <param name="s1">Sayı 1</param>
        /// <param name="s2">Sayı 2</param>
        /// <returns>OBEB</returns>
        public static int GreatestCommonDivisor (int s1, int s2) {
            int result = 1;
            int divide = 2;
            if (s1 == s2)
            {
                result = s1;
            } else
            {
                for (int i = 2; i < (s1 > s2 ? s1 : s2); i++)
                {
                    if (s1 % divide == 0 || s2 % divide == 0)
                    {
                        if (s1 % divide == 0 && s2 % divide == 0)
                        {
                            result *= divide;
                        }
                        if (s1 % divide == 0)
                        {
                            s1 /= divide;
                        }
                        if (s2 % divide == 0)
                        {
                            s2 /= divide;
                        }
                    } else
                    {
                        divide++;
                    }
                }
            }
            
            return result;
        }

        public static int Factorial (int n) {
            if (n <= 1)
            {
                return 1;
            }
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            
            return f;
        }
    }
}