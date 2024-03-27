namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(2,4);

            Matrix.PrintMatrix(Matris);

            int[,] transpose = Matrix.Transposition(Matris);

            Console.WriteLine("Matrisin tranpozu: ");
            Matrix.PrintMatrix(transpose);
        }
    }
    
}