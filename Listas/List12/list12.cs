// Crie uma lista de produtos com informações como nome, preço e quantidade em estoque. Imprima os produtos com preço acima de um valor especificado.
using List12;


// Metodo : Melhorado
var listaProdutos = new List<Produtos>();
listaProdutos.Add(new Produtos() { nome = "Banana", preco = 1.50, quantEstoque = 100 });
listaProdutos.Add(new Produtos() { nome = "Laranja", preco = 2.50, quantEstoque = 90 });
listaProdutos.Add(new Produtos() { nome = "Uva", preco = 6.50, quantEstoque = 1000 });
foreach(var item in listaProdutos) {
    if (item.preco > 2) {
        Console.WriteLine(item.nome);
    }
}

/* Metodo : Da certo mas pode melhorar
var banana = new Produtos() { nome = "Banana", preco = 1.50, quantEstoque = 100 };
var laranja = new Produtos() { nome = "Laranja", preco = 2.50, quantEstoque = 90 };
var uva = new Produtos() { nome = "Uva", preco = 6.50, quantEstoque = 1000 };
var kiwi = new Produtos() { nome = "Kiwi", preco = 11.75, quantEstoque = 10 };

if (banana.preco > 2)
{
    Console.WriteLine(banana.nome);
}

if (laranja.preco > 2) {
    Console.WriteLine(laranja.nome);
}

if (uva.preco > 2) {
    Console.WriteLine(uva.nome);
}

if (kiwi.preco > 2) {
    Console.WriteLine(kiwi.nome);
}

*/