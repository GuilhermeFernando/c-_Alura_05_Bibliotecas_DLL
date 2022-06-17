using ByteBank.Modelos;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoHelper _autenticavelHelper = new AutenticacaoHelper();
        public string  Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf) : base (salario, cpf)
        {}

        public bool Autenticar(string senha)
        {
            return _autenticavelHelper.ComprarSenhas(Senha, senha);
        }
    }
}
