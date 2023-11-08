List<int> numeros = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int soma = 0;
foreach (var i in numeros)
{
    if (i % 2 != 0)
    {
        soma = soma + i;
    }
}
Console.WriteLine(soma);