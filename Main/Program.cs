using AljabarLibraries;

Double[] AkarPersamaanKuadrat = AljabarLibraries.Cuadric.AkarPersamaanKuadrat(new double[] {1,-3,-10});
Double[] HasilKuadrat = AljabarLibraries.Cuadric.HasilKuadrat(new double[] {2, -3});

Console.WriteLine($"Akar Pesamaan Kuadrat X^2-3x-10 = 0 yaitu :\n" +
    $"X1 = {AkarPersamaanKuadrat[0]}\n" +
    $"X2 = {AkarPersamaanKuadrat[1]}\n\n" +
    $"Hasil Quadrat dari (2x-3)^2 : {HasilKuadrat[0]}x^2{HasilKuadrat[1]}x+{HasilKuadrat[2]}\n" +
    $"Hasil Dalam bentuk array : {{{string.Join(", ", HasilKuadrat)}}}");

