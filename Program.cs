namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(2,4);

            Matrix.PrintMatrix(Matris);

            int[,] X = Matrix.ScalarMultiplication(2,Matris);

            Console.WriteLine("Skaler çarpım: ");
            Matrix.PrintMatrix(X);

        }
    }
    
}