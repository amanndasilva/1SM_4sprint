using System.Collections.Generic;
using E_Players_AspNETCore.Models;

namespace E_Players_AspNETCore.Interfaces
{
    public interface IEquipe
    {
        //Criar
        void Creat(Equipe e);

        //Ler
        List<Equipe> ReadAll();

        //ALterar
        void Update(Equipe e);

        //Excluir
        void Delete(int idEquipe);
    }
}