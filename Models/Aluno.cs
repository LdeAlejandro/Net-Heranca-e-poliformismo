using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heranca_polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
        public string Email { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e sou um aluno nota {Nota}, meu email é {Email}.");
        }

    }
}