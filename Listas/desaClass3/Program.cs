using desaClass3;
var pessoa  = new Pessoa() {nome = "Lucas", idade = 18, cidade = "Cruz-Alta" };
var pessoa2  = new Pessoa() {nome = "Igor", idade = 20, cidade = "Horizontina" };
var pessoa3  = new Pessoa() {nome = "Pedro", idade = 42, cidade = "São Paulo" };

Console.WriteLine($"Nome: {pessoa.nome} Idade: {pessoa.idade} Cidade de residência: {pessoa.cidade} ");
Console.WriteLine($"Nome: {pessoa2.nome} Idade: {pessoa2.idade} Cidade de residência: {pessoa2.cidade} ");
Console.WriteLine($"Nome: {pessoa3.nome} Idade: {pessoa3.idade} Cidade de residência: {pessoa3.cidade} ");