// =============================================================================
// PessoasCaptadasRepository.cs
// 
// Autor  : Igor Fernandes Rabelo
// Data   : 26/01/2022
// =============================================================================
using ProjectZ.Data;
using ProjectZ.Model;
using ProjectZ.Repository.Interface;

namespace ProjectZ.Repository
{
    public class PessoasCaptadasRepository : IPessoasCaptadasRepository
    {
        #region Variáveis
        private readonly ApplicationContext _context;
        #endregion

        #region Construtores
        public PessoasCaptadasRepository( ApplicationContext context )
        {
            _context = context;
        }
        #endregion

        #region Métodos/Operadores Públicos
        public dynamic ListAll()
        {
            var pessoas = _context.pessoas_captadas
                .Select(x => new PessoasCaptadasModel
                {
                    id = x.id,
                    numero_solicitacao = x.numero_solicitacao,
                    quantidade_pessoas_solicitadas = x.quantidade_pessoas_solicitadas,
                    quantidade_pessoas_captadas = x.quantidade_pessoas_captadas,

                }).Take(10).ToList();

            return pessoas;
        }
        #endregion
    }
}