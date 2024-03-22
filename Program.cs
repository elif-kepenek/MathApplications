namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            int[] integerFactorization = NumberTheory.IntegerFactorization(60);
            Statistics.ArrayPrint(integerFactorization);
        }
    }
    
}