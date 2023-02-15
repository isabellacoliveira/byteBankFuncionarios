using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
        // assim estou passando o salário diretamente de acordo com o cargo 
        public Diretor(string cpf): base(cpf, 5000)
        {
            Console.WriteLine("Adicionando um diretor");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }    
}
