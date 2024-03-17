namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            Console.WriteLine("Kaç veriden oluşacak? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] datas = new Statistics().CreateData(n);
            Console.WriteLine("\nDizinin standart sapması: {0:F2}", Statistics.StandardDeviation(datas));
        }
    }
    
}