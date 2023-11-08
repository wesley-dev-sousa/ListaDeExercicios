List<int> numeros = new() { 1, 2, 3, 4 };
List<int> numerosDois = new() { 5, 6, 7, 8 };
List<int> numerosTres = new() { };


for (int i = 0; i < numeros.Count; i++) {
    numerosTres.Add(numeros[i]);
}
for (int i = 0; i < numerosDois.Count; i++) {
    numerosTres.Add(numerosDois[i]);
}

foreach (var i in numerosTres) {
    Console.Write($" {i} ");
}