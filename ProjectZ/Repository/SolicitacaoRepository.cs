

using ProjectZ.Data;
using ProjectZ.Model;
using ProjectZ.Repository.Interface;

namespace ProjectZ.Repository
{
    public class SolicitacaoRepository : ISolicitacaoRepository
    {

        private readonly ApplicationContext _context;

        public SolicitacaoRepository(ApplicationContext context)
        {
            _context = context;
        }

        //Metodo responsável por recolher as informações no banco de dados e retornar os valores
        public dynamic ListAllSolicitations()
        {
            var solicitacaos = _context.solicitacao
            .Select(x => new SolicitacaoModel
            {
                id = x.id,
                Nome_Lider = x.Nome_Lider,
                Nome_Cidade = x.Nome_Cidade,
                Nome_Estado = x.Nome_Estado,
                Solicitante = x.Solicitante,
                Quantidade_Pessoas = x.Quantidade_Pessoas
              
            }).Take(10).ToList();

            return solicitacaos;

        }
    }
}
