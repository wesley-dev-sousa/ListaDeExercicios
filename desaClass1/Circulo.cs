using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desaClass1 {
    public class Circulo {
        public int raio { get; set; }
        public void Calc() {
            int soma = (int)(2 * Math.PI * raio);
            Console.WriteLine($"O Perimetro é: {soma}");
        }
    }
}
