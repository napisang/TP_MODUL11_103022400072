using AljabarLibraries;

Console.WriteLine("=== ALJABAR LIBRARIES ===\n");

double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
Console.WriteLine("AkarPersamaanKuadrat({1, -3, -10})");
Console.WriteLine($"Output: {{{string.Join(", ", akar)}}}");

Console.WriteLine();
double[] hasil = Aljabar.HasilKuadrat(new double[] { 2, -3 });
Console.WriteLine("HasilKuadrat({2, -3})");
Console.WriteLine($"Output: {{{string.Join(", ", hasil)}}}");