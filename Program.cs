namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.LowerTriangularMatrix();

            Matrix.PrintMatrix(Matris);

            Console.WriteLine("{0}", Matrix.IsItLowerTriangularMatrix(Matris) ? "Alt üçgen matris" : "Alt üçgen matris değil");
        }
    }
    
}