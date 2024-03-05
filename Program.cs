namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {

            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1'den {0}'e kadar olan çift sayıların toplamı: {1}", n, Number.SumOfEvenNumbersUpTo_n(n));
            Console.WriteLine("1'den {0}'e kadar olan çift sayıların toplamı: {1}", n, Number.SumOfEvenNumbersUpTo_n1(n));
            Console.WriteLine("1'den {0}'e kadar olan çift sayıların toplamı: {1}", n, Number.FormulaForSumOfEvenNumbersUpTo_n(n));
            
        }
    }
    
}