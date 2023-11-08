string[] strings = { "Joao", "Maicol", "Luan", "Bianca", "Igor", "Wesley" };

StringComparer ordem = StringComparer.CurrentCultureIgnoreCase;

Array.Sort(strings, ordem);


foreach (var i in strings) {
    Console.WriteLine(i);
}
