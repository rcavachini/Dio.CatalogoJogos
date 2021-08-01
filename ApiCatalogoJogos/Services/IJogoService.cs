using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoJogos.Models.InputModel;
using ApiCatalogoJogos.Models.ViewModel;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService
    {
        public Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        public Task<JogoViewModel> Obter(Guid id);
        public Task<JogoViewModel> Inserir(JogoInputModel jogo);
        public Task Atualizar(Guid id, JogoInputModel jogo);
        public Task Atualizar(Guid id, double preco);
        public Task Remover(Guid id);

    }
}
