using System.Collections.Generic;
using E_Players_AspNETCore.Models;

namespace E_Players_AspNETCore.Interfaces
{
    public interface INoticias
    {
        //Criar
        void Create(Noticias n);

        //Ler
        List<Noticias> ReadAll();

        //Alterar
        void Update(Noticias n);

        //Deletar
        void Delete(int idNoticias);
    }
}