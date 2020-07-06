using System.Collections.Generic;

namespace Aula31WatsAppConsole
{
    public interface IAgenda
    {
        void Cadastrar(Contato contato);
        void Excluir(Contato contato);
        List<Contato> Listar();
    }
}