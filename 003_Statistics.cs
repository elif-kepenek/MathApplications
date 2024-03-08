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
        }
    }
}