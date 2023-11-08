//Desenvolva um programa que leia uma lista de palavras do usuário e retorne a palavra mais longa da lista.
List<string> palavras = new List<string>();

string c;

do {
    Console.WriteLine("Digite uma palavra ou digite fim para terminar a operação");
    c = Console.ReadLine();
    palavras.Add(c);

} while (c != "fim");


int a = 0;
string b = "";
foreach (var i in palavras)
{
    if(i.Length > a) {
        b = i;
        a = i.Length;
    }

}

Console.WriteLine(b);