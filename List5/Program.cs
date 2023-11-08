List<int> numeros = new();
int input;
string stop;
do 
{
    input = Convert.ToInt32(Console.ReadLine());
    numeros.Add(input);
    Console.WriteLine("Se deseja parar, escreva fim, se deseja continuar, escreva sim");
    stop = Console.ReadLine();

} while (stop != "fim");

int menor = numeros.Min();
numeros.Remove(menor);

menor = numeros.Min();
Console.WriteLine($"O segundo menor numero é {menor}");