using System;

namespace Primeiro
{
    class Program
    {
        static void Main()
        { 
            double valorDaConta = 0.00; 

            Console.Write("Entre com o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string InicialValue = Console.ReadLine();

            if (InicialValue == "s")
            {
               Console.Write("Entre com o valor inicial do depósito: ");
               valorDaConta = double.Parse(Console.ReadLine());
            }

            Conta p = new Conta(numeroDaConta, nome, valorDaConta);

            Console.WriteLine("Dados da conta:"); 
            Console.WriteLine(p);

            Console.WriteLine("Entre com o valor para o Deposito: "); 
            double quantidadeDeposito = double.Parse(Console.ReadLine());
            p.DepositoValor(quantidadeDeposito);

            Console.WriteLine("Dados da conta Atualizado: "); 
            Console.WriteLine(p);

            Console.WriteLine("Entre com o valor para o Saque: "); 
            double quantidadeSaque = double.Parse(Console.ReadLine());
            p.SacarValor(quantidadeSaque);

            Console.WriteLine("Dados da conta Atualizado: "); 
            Console.WriteLine(p);
        }
    }
}
