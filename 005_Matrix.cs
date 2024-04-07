using MathAplications.Helper;

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

        /// <summary>
        /// Birim matris olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Birim matris ise true birim matris değil ise false</returns>
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

        /// <summary>
        /// Diagonal elemanların listesini dizi olarak döner.
        /// </summary>
        /// <param name="M">Dizi</param>
        /// <returns>Diagonal elemanlar</returns>
        public static int[] DiagonalElements (int[,] M) {
            
            if (IsItSquareMatrix(M))
            {
                int[] datas = new int[M.GetLength(0)];
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    datas[i] = M[i, i];
                }
                return datas;
            }
            else
            {
                Console.WriteLine("Lütfen kare matris giriniz.");
                return new int[1];
            }

        }

        /// <summary>
        /// Girilen matrisin izini hesaplar
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Matrisin izi</returns>
        public static int Trace (int[,] M) {
            int total = 0;
            if (IsItSquareMatrix(M))
            {
                int[] diagonalElements = DiagonalElements(M);
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    total += M[i, i];
                }
            } else
            {
                Console.WriteLine("Lütfen kare matris giriniz.");
            }
            return total;   
        }

        /// <summary>
        /// Girilen matrisin transpozunu alır.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Tranpoz</returns>
        public static int[,] Transposition (int[,] M) {
            int[,] transpose = new int[M.GetLength(1), M.GetLength(0)];

            for (int i = 0; i < transpose.GetLength(0); i++)
            {
                for (int j = 0; j < transpose.GetLength(1); j++)
                {
                    transpose[i, j] = M[j, i];
                }
            }
            return transpose;
        }

        /// <summary>
        /// Girilen matrisin değerleriyle yeni satır ve sütun bilgisi girilen matris oluşturur.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <param name="newRow">Yeni satır</param>
        /// <param name="newColumn">Yeni sütun</param>
        /// <returns>Yeniden şekillendirilmiş matris</returns>
        public static int[,] Reshape (int[,] M, int newRow, int newColumn) {
            if (M.Length == newRow * newColumn)
            {
                int[] D = new int[M.Length];
                int counter = 0;
                int[,] Y = new int[newRow, newColumn];

                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        D[counter] = M[i,j];
                        counter++;
                    }
                }
                Helper.Helper.ArrayPrint(D);

                counter = 0;
                for (int i = 0; i < Y.GetLength(0); i++)
                {
                    for (int j = 0; j < Y.GetLength(1); j++)
                    {
                        Y[i,j] = D[counter];
                        counter++;
                    }
                }
                return Y;

            } else
            {
                Console.WriteLine("Bir hata oluştu.");
                return new int[1,1];
            }
            
        }

        /// <summary>
        /// Matrislerin eşit olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="M">Matris 1</param>
        /// <param name="N">Matris 2</param>
        /// <returns>Eşit ise true eşit değilse false</returns>
        public static bool IsItEqualMatrix (int[,] M, int[,] N) {
            bool result = true;

            if (M.GetLength(0) == N.GetLength(0) && M.GetLength(1) == N.GetLength(1))
            {
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        if (M[i, j] != N[i ,j])
                        {
                            result = false;
                            break;
                        }
                    }
                }
            } else
            {
                result = false;
            }
            
            return result;
        }

        /// <summary>
        /// Matrisin determinantını hesaplar.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Determinant</returns>
        public static int Determinant (int[,] M) {

            int d = -1;
            if (IsItSquareMatrix(M))
            {
                if (M.Length == 4)
                {
                    d = M[0,0] * M[1,1] - M[0,1] * M[1,0];
                } else if (M.Length == 9)
                {
                    d = M[0,0] * (M[1,1] * M[2,2] - M[1,2] * M[2,1]) - 
                        M[0,1] * (M[1,0] * M[2,2] - M[2,0] * M[1,2]) + 
                        M[0,2] * (M[1,0] * M[2,1] - M[1,1] * M[2,0]);
                } else
                {
                    Helper.Helper.PrintError("Tanımlı boyut yok!");
                }
            return d;

            } else
            {
                Helper.Helper.PrintError("Kare matris olmalı!");
                return -1;
            }
            
        }

        /// <summary>
        /// Skaler çarpımını döner.
        /// </summary>
        /// <param name="c">Skaler sayı</param>
        /// <param name="M">Matris</param>
        /// <returns>Skaler çarpım</returns>
        public static int[,] ScalarMultiplication (int c, int[,] M) {
            
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    M[i,j] = c * M[i,j];
                }
            }
            return M;
        }

        /// <summary>
        /// Girilen matrisin elemanlarının toplamını döner.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Elemanlar toplamı</returns>
        public static int SumOfElements (int[,] M) {
            int total = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    total += M[i,j];
                }
            }
            return total;
        }

        /// <summary>
        /// Simetrik matris oluşturur.
        /// </summary>
        /// <param name="dimension">Boyut</param>
        /// <param name="min">Min değer</param>
        /// <param name="max">Max değer</param>
        /// <returns>Simetrik matris</returns>
        public static int[,] CreateSymmetricMatrix (int dimension = 3, int min = 1, int max = 9) {

            int[,] M = DiagonalMatrix(dimension, min, max);

            for (int i = 1; i < M.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    M[i,j] = new Random().Next(min, max);
                    M[j,i] = M [i,j];
                }
            }
            return M;
        }

        /// <summary>
        /// Matrisin simetrik olup olmadığını döner.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Simetrik ise true değilse false</returns>
        public static bool IsItSymmetricMatrix (int[,] M) {

            int[,] N = Transposition(M);

            return IsItEqualMatrix(M, N);
        }

        /// <summary>
        /// Köşegen matris olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Köşegen matris ise true değilse false</returns>
        public static bool IsItDiagonalMatrix (int[,] M) {
            bool result = true;
            if (IsItSquareMatrix(M))
            {
                for (int i = 0; i < M.GetLength(0); i++)
                {
                    for (int j = 0; j < M.GetLength(1); j++)
                    {
                        if (!(M[i,j] == 0))
                        {
                            if (i != j)
                            {
                                result = false;
                                break;
                            }
                        }
                    }
                }
            } else
            {
                Helper.Helper.PrintError("Kare matris değil!");
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Üst üçgen matris oluşturur.
        /// </summary>
        /// <param name="dimension">Boyut</param>
        /// <param name="min">Min değer</param>
        /// <param name="max">Max değer</param>
        /// <returns>Üst üçgen matris</returns>
        public static int[,] UpperTriangularMatrix (int dimension = 3, int min = 1, int max = 9) {
            int[,] M = DiagonalMatrix(dimension, min, max);

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = i; j < M.GetLength(1); j++)
                {
                    M[i,j] = new Random().Next(min, max);
                }
                
            }
            
            return M;
        }

        /// <summary>
        /// Matrisin üst üçgen matris olup olmadığını döner.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Üst üçgen ise true değilse false</returns>
        public static bool IsItUpperTriangularMatrix (int[,] M) {
            bool result = true;
            for (int i = 1; i < M.GetLength(0); i++)
            {
                for (int j = 0; j <= i - 1 ; j++)
                {
                    if (!(M[i,j] == 0))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Alt üçgen matris oluşturur.
        /// </summary>
        /// <param name="dimension">Boyut</param>
        /// <param name="min">Min değer</param>
        /// <param name="max">Max değer</param>
        /// <returns>Alt üçgen matris</returns>
        public static int[,] LowerTriangularMatrix (int dimension = 3, int min = 1, int max = 9) {
            int[,] M = DiagonalMatrix(dimension, min, max);

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    M[i,j] = new Random().Next(min, max);
                }
            }

            return M;
        }

        /// <summary>
        /// Matrisin alt üçgen matris olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="M">Matris</param>
        /// <returns>Alt üçgen matris ise true değilse false</returns>
        public static bool IsItLowerTriangularMatrix (int[,] M) {
            bool result = true;
            
            for (int i = 0; i < M.GetLength(0) - 1; i++)
            {
                for (int j = i + 1; j < M.GetLength(1); j++)
                {
                    if (!(M[i,j] == 0))
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;
        }


    }
}