List<string> palavras = new List<string>() {"Joao", "Maicol", "Luan","Bianca","Igor","Wesley" };

Console.WriteLine("Adicione um nome ao inicio:");
palavras.Insert(0, Console.ReadLine());

Console.WriteLine("Adicione um nome ao final:");
palavras.Add(Console.ReadLine());

foreach (var i in palavras)
{

    Console.Write($" {i} ");
}
