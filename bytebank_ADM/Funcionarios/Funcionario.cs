using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    // não podemos colocar objetos diretamente 
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        // esse método será abstrato
        // toda classe que herde de funcionário tem a obrigação de 
        // implementar esse comportamento 
        public abstract double GetBonificacao();
        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario; 
            this.Cpf = cpf; 
            TotalDeFuncionarios++;   
        }
        // esse método será abstrato
        public abstract void AumentarSalario();
    }
}
