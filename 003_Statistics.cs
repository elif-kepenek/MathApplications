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
        /// 
        /// </summary>
        /// <param name="datas"></param>
        /// <returns></returns>
        public static double ArithmeticMean (int[] datas) {
            double total = 0;
            for (int i = 0; i < datas.Length; i++)
            {
                total += datas[i];
            }
            return total / datas.Length;
        }

    }
}