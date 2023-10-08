using System;

namespace Primeiro
{
    class Conta
    {
        public string Nome { get; set; }
        public int NumeroDaConta { get; private set; }
        public double ValorDaConta { get; private set; }

        public Conta(int numeroDaConta, string nome)
        {
            Nome = nome;
            NumeroDaConta = numeroDaConta;
        }
        public Conta(int numeroDaConta, string nome, double depositoInicial): this( numeroDaConta, nome)
        {
            DepositoValor(depositoInicial);
        }
        public void DepositoValor(double quantinha)
        {
            ValorDaConta += quantinha;
        }

        public void SacarValor(double quantinha)
        {
            double taxa = 5.00;
            ValorDaConta -= (quantinha + taxa);
        }
        public override string ToString()
        {
            return "Conta "+ NumeroDaConta + ", Titular: " + Nome + ", Saldo: R$ " + ValorDaConta + " .";
        }
    }
}