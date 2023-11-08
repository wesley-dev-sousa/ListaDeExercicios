// Crie uma lista de números inteiros e divida todos os elementos por um valor fornecido pelo usuário.

List<int> numeros = new List<int>() { 2, 4, 6, 8, 10, 12, 24 };

foreach (var i in numeros) {
    Console.Write($" {i} ");
}
Console.WriteLine();
Console.WriteLine("Defina um divisor");
double divisor = Convert.ToDouble(Console.ReadLine());
double divisao;
foreach (var i in numeros)
{
    divisao = Convert.ToDouble(i / divisor);
    Console.WriteLine(divisao);
}