namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double discriminant = (b * b) - (4 * a * c);

            if (discriminant < 0)
                throw new Exception("Persamaan tidak memiliki akar real.");

            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            if (x1 < x2) { double temp = x1; x1 = x2; x2 = temp; }

            return new double[] { x1, x2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            return new double[] { a * a, 2 * a * b, b * b };
        }
    }
}   