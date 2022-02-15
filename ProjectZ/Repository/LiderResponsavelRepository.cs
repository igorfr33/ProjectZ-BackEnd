
using ProjectZ.Data;
using ProjectZ.Model;
using ProjectZ.Repository.Interface;

namespace ProjectZ.Repository
{
    public class LeaderResponsavelRepository : ILiderResponsavelRepository
    {

        private readonly ApplicationContext _context;

        public LeaderResponsavelRepository(ApplicationContext context)
        {
            _context = context;
        }

        //Metodo responsável por recolher as informações no banco de dados e retornar os valores
        public dynamic ListAllLeaders()
        {
            var liderResponsaveis = _context.lider_resposavel
            .Select(x => new LiderResponsavelModel
            {
                id = x.id,
                Nome_Lider = x.Nome_Lider,
                Nome_Cidade = x.Nome_Cidade,
                Nome_Estado = x.Nome_Estado,

            }).Take(10).ToList();

            return liderResponsaveis;

        }
    }
}
