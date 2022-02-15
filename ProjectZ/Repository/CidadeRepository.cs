
using ProjectZ.Data;
using ProjectZ.Model;
using ProjectZ.Repository.Interface;

namespace ProjectZ.Repository
{
    public class CidadeRepository : ICidadeRepository
    {

        private readonly ApplicationContext _context;

        public CidadeRepository(ApplicationContext context)
        {
            _context = context;
        }

        //Metodo responsável por recolher as informações no banco de dados e retornar os valores
        public dynamic ListAllCities()
        {
            var cidades = _context.cidade
            .Select(x => new CidadeModel
            {
                id = x.id,
                Nome_Lider = x.Nome_Lider,
                Nome_Cidade = x.Nome_Cidade,
                Nome_Estado = x.Nome_Estado,

            }).Take(10).ToList();

            return cidades;

        }
    }
}
