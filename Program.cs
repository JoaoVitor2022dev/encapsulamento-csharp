using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main()
        { 
            Conta contaBancaria; 

            double DepositoInicial = 0.00;

            Console.Write("Entre com o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());
            
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char InicialValue = char.Parse(Console.ReadLine());

            if (InicialValue == 's' || InicialValue == 'S' )
            {
               Console.Write("Entre com o valor inicial do depósito: ");
               DepositoInicial = double.Parse(Console.ReadLine());
               contaBancaria = new Conta(numeroDaConta, nome, DepositoInicial);
            } else {
               contaBancaria = new Conta(numeroDaConta, nome, DepositoInicial );
            }

            Console.WriteLine("Dados da conta:"); 
            Console.WriteLine(contaBancaria);

            Console.WriteLine("Entre com o valor para o Deposito: "); 
            double quantidadeDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.DepositoValor(quantidadeDeposito);

            Console.WriteLine("Dados da conta Atualizado: "); 
            Console.WriteLine(contaBancaria);

            Console.WriteLine("Entre com o valor para o Saque: "); 
            double quantidadeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.SacarValor(quantidadeSaque);

            Console.WriteLine("Dados da conta Atualizado: "); 
            Console.WriteLine(contaBancaria);
        }
    }
}
