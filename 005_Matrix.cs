namespace MathAplications
{
    public class Matrix {

        /// <summary>
        /// Matris oluşturur.
        /// </summary>
        /// <param name="row">Satır</param>
        /// <param name="column">Sütun</param>
        /// <param name="min">Min Değer</param>
        /// <param name="max">Max Değer</param>
        /// <returns>Matris</returns>
        public static int[,] CreateMatrix (int row = 3, int column = 3, int min = 1, int max = 9) {
            
            int[,] M = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    M[i, j] = new Random().Next(min, max);
                }
            }

            return M;
        }

        /// <summary>
        /// Parametre olarak aldığı matrisi yazdırır.
        /// </summary>
        /// <param name="M">Matris</param>
        public static void PrintMatrix (int[,] M) {

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,3}", M[i,j]);
                }
                Console.WriteLine();
            }            
        }

        /// <summary>
        /// Sıfır matris oluşturur.
        /// </summary>
        /// <param name="row">Satır</param>
        /// <param name="column">Sütun</param>
        /// <returns>Sıfır matris</returns>
        public static int[,] ZeroMatrix (int row, int column) {
            return CreateMatrix(row, column, 0, 0);
        }

        /// <summary>
        /// Birler matrisi oluşturur.
        /// </summary>
        /// <param name="row">Satır</param>
        /// <param name="column">Sütun</param>
        /// <returns>Birler matrisi</returns>
        public static int[,] MatrixOfOnes (int row, int column) {
            return CreateMatrix(row, column, 1, 1);
        }

        /// <summary>
        /// Köşegen (Diagonal) matris oluşturur.
        /// </summary>
        /// <param name="dimension">Satır ve sütun sayısı</param>
        /// <param name="min">Min değer</param>
        /// <param name="max">Max değer</param>
        /// <returns>Diagonal matris</returns>
        public static int[,] DiagonalMatrix (int dimension = 3, int min = 1, int max = 9) {
            int[,] M = ZeroMatrix(dimension, dimension);

            for (int i = 0; i < dimension; i++)
            {
                M[i,i] = new Random().Next(min, max);
            }

            return M;
        }

        /// <summary>
        /// Skaler matris oluşturur.
        /// </summary>
        /// <param name="dimension">Satır ve sütun</param>
        /// <param name="scalar">Köşegenler üzerindeki değer</param>
        /// <returns>Skaler matris</returns>
        public static int[,] ScalarMatrix (int dimension = 3, int scalar = 3) {
            return DiagonalMatrix(dimension, scalar, scalar);
        }
        
        /// <summary>
        /// Kare matris olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Kare matris ise true değil ise false</returns>
        public static bool IsItSquareMatrix (int[,] M) {
            return M.GetLength(0) == M.GetLength(1) ? true : false;
        }

        /// <summary>
        /// Birim matris oluşturur.
        /// </summary>
        /// <param name="dimension">Satır ve sütun</param>
        /// <returns>Birim matris</returns>
        public static int[,] IdentityMatrix (int dimension = 3) {
            return ScalarMatrix(dimension, 1);
        }

        public static bool IsItIdentityMatrix (int[,] M) {
            bool control = true;
            for (int i = 0; (i < M.GetLength(0) && control == true); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    // diagonal elemanlar dışındakiler 0 mı?
                    if (M[i,j] != 0 && i != j)
                    {
                        control = false;
                        break;
                    }
                    // diagonal elemanlar 1 mi?
                    else
                    {
                        if (M[i,j] != 1 && i == j)
                        {
                            control = false;
                            break;
                        }
                    }
                }
            }
            return control;
        }

    }
}