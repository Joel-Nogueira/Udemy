using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosClasse
{
    class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa(String Nome, int Idade)
        {
            SetNome(Nome);
            SetIdade(Idade);
        }

        private string GetNome()
        {
            return _nome;
        }

        private void SetNome(string value)
        {
            _nome = value;
        }

        private int GetIdade()
        {
            return _idade;
        }

        private void SetIdade(int value)
        {
            _idade = value;
        }

        public static string MaisVelha(Pessoa A, Pessoa B)
        {
            if (A.GetIdade() > B.GetIdade())
            {
                return "A pessoa mais velha é: " + A.GetNome() + ".";
            }
            else if (A.GetIdade() < B.GetIdade())
            {
                return "A pessoa mais velha é: " + B.GetNome() + ".";
            }
            else
            {
                return A.GetNome() + " e " + B.GetNome() + "possuem a mesma idade.";
            }
        }

        public override string ToString()
        {
            return "Nome: " + GetNome() + ", Idade: " + GetIdade();
        }
    }
}
