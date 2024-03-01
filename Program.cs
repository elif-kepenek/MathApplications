namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}", 
            Number.PrimeNumber(n) ? "Asal sayı": "Asal değil.");
            
        }
    }
    
}