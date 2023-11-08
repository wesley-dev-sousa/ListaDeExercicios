// Crie uma classe "Círculo" com métodos para calcular a área e o perímetro. Peça ao usuário para inserir o raio de um círculo e exiba a área e o perímetro.
using desaClass1;

Console.WriteLine("Defina o Raio do circulo:");
var obj = new Circulo() { raio = Convert.ToInt32(Console.ReadLine()) };
obj.Calc();