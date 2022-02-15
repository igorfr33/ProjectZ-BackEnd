// =============================================================================
// ListaPresencaRepository.cs
// 
// Autor  : Igor Fernandes Rabelo
// Data   : 03/02/2022
// =============================================================================
using ProjectZ.Data;
using ProjectZ.Model;
using ProjectZ.Repository.Interface;

namespace ProjectZ.Repository
{
    public class ListaPresencaRepository : IListaPresencaRepository
    {
        #region Variáveis
        private readonly ApplicationContext _context;
        #endregion

        #region Construtores
        public ListaPresencaRepository( ApplicationContext context )
        {
            _context = context;
        }
        #endregion

        #region Métodos/Operadores Públicos
        public dynamic ListAll()
        {
            var pessoas = _context.lista_presenca
                .Select( x => new ListaPresencaModel
                {
                    nome_terceiro = x.nome_terceiro ,

                } ).Take( 10 ).ToList();

            return pessoas;
        }
        #endregion
    }
}