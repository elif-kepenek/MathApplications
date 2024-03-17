namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            Console.WriteLine("Kaç veriden oluşacak? ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new Statistics().CreateData(n);

            Statistics array = new Statistics();
            Statistics.ArrayPrint(newArray);
            
            int[] arrayOfOddNumbers = array.CreateOddArray(newArray);
            Statistics.ArrayPrint(arrayOfOddNumbers);
            Console.WriteLine("\nTek sayıların sayısı: {0, 5}", Statistics.NumberOfOddNumbers(arrayOfOddNumbers));

            int[] arrayOfEvenNumbers = array.CreateEvenArray(newArray);
            Statistics.ArrayPrint(arrayOfEvenNumbers);
            Console.WriteLine("\nÇift sayıların sayısı: {0, 5}", Statistics.NumberOfEvenNumbers(arrayOfEvenNumbers));

        }
    }
    
}