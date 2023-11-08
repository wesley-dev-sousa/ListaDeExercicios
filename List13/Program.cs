// Implemente uma função que remova todos os elementos duplicados de uma lista.

List<int> numeros = new() { 1, 2, 3, 2, 2, 1, 4, 5, 6 };

var semRepetir = numeros.Distinct().ToList();


foreach (var i in semRepetir)
{
    Console.WriteLine(i);
}