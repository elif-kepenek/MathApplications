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
    

    }
}