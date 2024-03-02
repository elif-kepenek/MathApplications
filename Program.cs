namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1'den {0}'e kadar olan sayıların toplamı: {1}", n, Number.FormulaSumOfNumbersUpTo_n(n));
            
        }
    }
    
}