namespace MathAplications
{
    public class Statistics {
        public static void CreateData () {
            Console.WriteLine("Kaç veriden oluşacak? ");
            int limit = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[limit];

            for (int i = 0; i < limit; i++)
            {
                numbers[i] = new Random().Next(0, 100);
                Console.Write("{0, 3}", numbers[i]);
            }
            Console.WriteLine("\nDizinin en büyük elemanı: {0} \nDizinin en küçük elemanı: {1}", BiggestData(numbers), SmallestData(numbers));
        }

        public static int BiggestData (int[] numbers) {
            int bigData = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > bigData)
                {
                    bigData = numbers[i];
                }
            }
            return bigData;
        }

        public static int SmallestData (int[] numbers) {
            int smallData = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallData)
                {
                    smallData = numbers[i];
                }
            }
            return smallData;
        }

    }
}