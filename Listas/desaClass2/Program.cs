using desaClass2;

var conta1 = new ContaBancaria() { saldo = 1000 };

int operação = 0;
while (operação != 4) {
    Console.WriteLine("Digite 1 para Deposito, Digite 2 para Saque, Digite 3 para Consultar o Saldo e Digite 4 para finalizar");

    operação = Convert.ToInt32(Console.ReadLine());



    switch (operação) {
        case 1:
            conta1.Depositar();
            break;
        case 2:
            conta1.Sacar();
            break;
        case 3:
            conta1.ConsultarSaldo();
            break;
    }
}