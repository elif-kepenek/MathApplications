namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.UpperTriangularMatrix();

            Matrix.PrintMatrix(Matris);

            Console.WriteLine("{0}", Matrix.IsItUpperTriangularMatrix(Matris) ? "Üst üçgen matris" : "Üst üçgen matris değil");
        }
    }
    
}