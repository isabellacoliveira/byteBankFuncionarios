using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.SistemaInterno
{
    // é como se fosse um contrato e quem o assina tem a obrigação de 
    // impelmentar esse comportamento 
    public interface IAutenticavel 
    {
        public string Senha { get; set; }
        public abstract bool Autenticar(string senha);
    }
}