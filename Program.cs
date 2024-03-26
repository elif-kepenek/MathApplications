namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.MatrixOfOnes(5, 3);
            Matrix.PrintMatrix(Matris);
            Console.WriteLine("{0}", Matrix.IsItSquareMatrix(Matris) ? "Kare matris" : "Kare matris değil");

        }
    }
    
}