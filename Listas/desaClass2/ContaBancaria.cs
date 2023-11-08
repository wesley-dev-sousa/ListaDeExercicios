using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desaClass2 {
    public class ContaBancaria {
        public int saldo { get; set; }

        public void Sacar() {
            Console.WriteLine("Digite o valor de saque");
            int saque = Convert.ToInt32(Console.ReadLine());
            
            if (saldo < saque) {
                Console.WriteLine("Não é possivel sacar, valor excede saldo");
            }
            else {
                saldo = saldo - saque;
            }
        }
        public void Depositar() {
            Console.WriteLine("Digite o valor de deposito");
            saldo = saldo + Convert.ToInt32(Console.ReadLine());
        }
        public void ConsultarSaldo() {

            Console.WriteLine($"Seu Saldo é: {saldo}");

        }
    }
}
