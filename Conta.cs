using System;

namespace Primeiro
{
    class Conta
    {
        public string _nome;
        public int NumeroDaConta { get; private set; }
        public double ValorDaConta { get; private set; }

        public Conta(int numeroDaConta, string nome, double valorDaConta)
        {
            _nome = nome;
            NumeroDaConta = numeroDaConta;
            ValorDaConta = valorDaConta;
        }
        public Conta(string nome, int numeroDaConta)
        {
            _nome = nome;
            NumeroDaConta = numeroDaConta;
            ValorDaConta = 0.0; 
        }
        public string Nome {
            get { return _nome; }
            private set { if (value != null && value.Length > 1)
            {
                _nome = value;
            }}
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
            return "Conta "+ NumeroDaConta + ", Titular: " + _nome + ", Saldo: R$ " + ValorDaConta + " .";
        }
    }
}