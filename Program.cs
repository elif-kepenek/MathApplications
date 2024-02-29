namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {

            int n = Convert.ToInt32(Console.ReadLine());
            if (Number.EvenNumber(n))
            {
                Console.WriteLine("Sayı çift");
            }
        }
    }
    
}