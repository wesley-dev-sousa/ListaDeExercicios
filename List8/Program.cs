List<string> frutas = new List<string>() { "Laranja", "Banana", "Pessego"};

string qualFruta = Console.ReadLine();

if (frutas.Contains(qualFruta)) {
    Console.WriteLine($"{qualFruta} está na lista");
}