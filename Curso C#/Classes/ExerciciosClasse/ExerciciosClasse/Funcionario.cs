using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosClasse
{
    class Funcionario
    {
        private string _nome;
        private double _salario;
        
        
        private string GetNome()
        {
            return _nome;
        }

        private void SetNome(string value)
        {
            _nome = value;
        }

        private double GetSalario()
        {
            return _salario;
        }

        private void SetSalario(double value)
        {
            _salario = value;
        }

        public Funcionario(String Nome, double Salario)
        {
            SetNome(Nome);
            SetSalario(Salario);
        }

        public static double SalarioMedio(Funcionario A, Funcionario B)
        {
            return (A.GetSalario() + B.GetSalario()) / 2;
        }

        public override string ToString()
        {
            return "Nome: " + GetNome() + ", Salário: " + GetSalario();
        }
    }
}
