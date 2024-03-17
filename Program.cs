namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            Console.WriteLine("Kaç veriden oluşacak? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] datas = new Statistics().CreateData(n);
            Console.WriteLine("\nTek sayıların sayısı: {0}", Statistics.NumberOfOddNumbers(datas));
        }
    }
    
}