namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] M = Matrix.DiagonalMatrix(3,1,1);
            int[,] N = Matrix.DiagonalMatrix(3,1,1);
            Matrix.PrintMatrix(M);
            Matrix.PrintMatrix(N);

            Console.WriteLine("{0}", Matrix.IsItEqualMatrix(M, N) ? "Matrisler eşit" : "Matrisler eşit değil");
        }
    }
    
}