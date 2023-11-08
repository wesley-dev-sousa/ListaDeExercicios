List<string> paises = new List<string>() { "Alemanha", "Alemanha", "Brasil", "Chile", "Paraguai", "Bolivia" };
var diferente = paises.Distinct().ToList();

Console.Write("Paises: ");

foreach (string nome in paises) {
    Console.Write(nome + " ");
}

Console.WriteLine();
Console.Write("Paises sem repetir: ");
foreach (var pais in diferente) {
    Console.Write($"{pais} ");
}

Console.WriteLine();