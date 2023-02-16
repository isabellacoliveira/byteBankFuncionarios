using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
// aqui vamos fazer um sistema de autenticação 
namespace bytebank_ADM.SistemaInterno 
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Seja bem vindo ao nosso sistema."); 
                return true; 
            }
            else 
            {
                Console.WriteLine("Senha incorreta"); 
                return false; 
            }
        }
    }
}