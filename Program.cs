namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.DiagonalMatrix(5);

            Matrix.PrintMatrix(Matris);

            int[] DiagonalElements = Matrix.DiagonalElements(Matris);

            Statistics.ArrayPrint(DiagonalElements);
        }
    }
    
}