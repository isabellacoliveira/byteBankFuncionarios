using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank_ADM.SistemaInterno;

namespace bytebank_ADM.Funcionarios
{
    // vai herdar de funcionario e implementar autenticavel 
    public class Diretor : FuncionarioAutenticavel
    {

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
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
