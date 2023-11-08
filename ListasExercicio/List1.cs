//Crie uma lista de números inteiros e encontre o maior valor na lista.
List<int> number = new List<int> { 110, 251, 3, 4, 5, 6, 55, 660, 668 };

var maior = 0;

foreach (var item in number) {
    if (item > maior) { maior = item; }
}
Console.WriteLine(maior);