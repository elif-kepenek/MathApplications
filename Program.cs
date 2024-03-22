namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            int[] primeFactorization = NumberTheory.PrimeFactorization(60);
            Statistics.ArrayPrint(primeFactorization);
        }
    }
    
}