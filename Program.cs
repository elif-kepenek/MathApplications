namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.UpperTriangularMatrix(5, -3, 9);

            Matrix.PrintMatrix(Matris);
        }
    }
    
}