namespace MathAplications
{
    public class Statistics {
        /// <summary>
        /// Girilen sayı kadar elamanlı 1-100 arasındaki sayılardan dizi oluşturur.
        /// </summary>
        public int[] CreateData (int n) {
          
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = new Random().Next(0, 100);
                Console.Write("{0, 3}", numbers[i]);
            }
            return numbers;
        }

        /// <summary>
        /// Sayılardan oluşan dizinin en büyük elemanını döner.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int BiggestData (int[] datas) {
            int bigData = datas[0];
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] > bigData)
                {
                    bigData = datas[i];
                }
            }
            return bigData;
        }

        /// <summary>
        /// Sayılardan oluşan dizinin en küçük elemanını döner.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int SmallestData (int[] datas) {
            int smallData = datas[0];
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] < smallData)
                {
                    smallData = datas[i];
                }
            }
            return smallData;
        }

        /// <summary>
        /// Veriler aritmetik ortalamasını hesaplar.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns></returns>
        public static double ArithmeticMean (int[] datas) {
            double total = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                total += datas[i];
            }
            return total / datas.Length;
        }

        /// <summary>
        /// Parametre olarak aldığı dizinin standart sapmasını hesaplar.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Standart sapma</returns>
        public static double StandardDeviation (int[] datas) {
            
            double arithmeticMean = ArithmeticMean(datas);
            double t = 0, f = 0;

            for (int i = 0; i < datas.Length; i++)
            {
                f = datas[i] - arithmeticMean;
                t += Math.Pow(f, 2);
            }

            return Math.Sqrt(t / (datas.Length - 1));
            
        }

        /// <summary>
        /// Parametre olarak aldığı dizinin içindeki tek sayıların sayısını döner.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Tek sayıların sayısı</returns>
        public static int NumberOfOddNumbers (int[] datas) {
            int numberOfOddNumbers = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] % 2 == 1)
                {
                    numberOfOddNumbers++;
                }
            }
            return numberOfOddNumbers;
        }

        /// <summary>
        /// Parametre olarak aldığı dizinin içindeki çift sayıların sayısını döner.
        /// </summary>
        /// <param name="datas">Dizi</param>
        /// <returns>Çift sayıların sayısı</returns>
        public static int NumberOfEvenNumbers (int[] datas) {
            int numberOfEvenNumbers = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                if (datas[i] % 2 == 0)
                {
                    numberOfEvenNumbers++;
                }
            }
            return numberOfEvenNumbers;
        }

    }
}