namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(4,3);

            Matrix.PrintMatrix(Matris);

            int[,] Y = Matrix.Reshape(Matris, 6, 3);

            Matrix.PrintMatrix(Y);
        }
    }
    
}