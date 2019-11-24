using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacaoConstrutores
{
    class Conta
    {
        public string Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string Numero, string Titular)
        {
            this.Numero = Numero;
            this.Titular = Titular;
        }

        public Conta(string Numero, string Titular, double Saldo): this(Numero, Titular)
        {
            this.Saldo = Saldo;
        }

        public void Depositar(double Dinheiro)
        {
            Saldo = Saldo + Dinheiro;
        }

        public void Sacar(double Dinheiro)
        {
            if (Saldo > 0.0)
                Saldo = Saldo - Dinheiro - 5.00;
        }

        public void AlterarTitular(string NovoTitular)
        {
            Titular = NovoTitular;
        }

        public override string ToString()
        {
            return "Dados da Conta\nTitular: " + Titular + ", Número: " + Numero + ", Saldo: " + Saldo.ToString();
        }
    }
}
