namespace AljabarLibraries;

public static class Cuadric
{
    public static double[] AkarPersamaanKuadrat(double[] persamaan)
    {
        return new double[]
        {
            (-persamaan[1] + Math.Sqrt(Math.Pow(persamaan[1],2) - 4*persamaan[0]*persamaan[2])) / (2*persamaan[0]),
            (-persamaan[1] - Math.Sqrt(Math.Pow(persamaan[1],2) - 4*persamaan[0]*persamaan[2])) / (2*persamaan[0])
        };
    }

    public static double[] HasilKuadrat(double[] persamaan)
    {
        return new double[]
        {
            Math.Pow(persamaan[0],2),
            persamaan[0] * persamaan[1] * 2,
            Math.Pow(persamaan[1],2)
        };
    }
}