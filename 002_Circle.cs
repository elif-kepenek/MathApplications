namespace MathAplications
{
    public class Circle {
        public const double pi = 3.14;

        /// <summary>
        /// Parametre olarak yarıçapı girilen çemberin çevresini hesaplar.
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <returns>Çemberin çevresi</returns>
        public static double PerimeterOfCircle (double r) {
            return 2 * pi * r;
        }

        /// <summary>
        /// Parametre olarak yarıçapı girlen dairenin alanını hesaplar.
        /// </summary>
        /// <param name="r">Yarıçap</param>
        /// <returns>Dairenin alanı</returns>
        public static double AreaOfTheCircle (double r) {
            return pi * r * r;
        }
    }
}