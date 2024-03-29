namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.LowerTriangularMatrix(5, -3, 9);

            Matrix.PrintMatrix(Matris);
        }
    }
    
}