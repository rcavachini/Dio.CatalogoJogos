using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoJogos.Entities;

namespace ApiCatalogoJogos.Repository
{
    public interface IJogoRepository:IDisposable
    {
        public Task<List<Jogo>> Obter(int pagina, int quantidade);
        public Task<Jogo> Obter(Guid id);
        public Task<List<Jogo>> Obter(string nome, string produtora);
        public Task Inserir(Jogo jogo);
        public Task Atualizar(Jogo jogo);
        public Task Remover(Guid id);
    }
}
