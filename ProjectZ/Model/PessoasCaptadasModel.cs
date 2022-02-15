// =============================================================================
// PessoasCaptadasModel.cs
// 
// Autor  : Igor Fernandes Rabelo
// Data   : 26/01/2022
// =============================================================================
namespace ProjectZ.Model
{
    public class PessoasCaptadasModel
    {
        #region Propriedades Públicas
        public int id{ get; set; }
        public int numero_solicitacao{ get; set; }
        public int quantidade_pessoas_solicitadas{ get; set; }
        public int quantidade_pessoas_captadas{ get; set; }
        #endregion
    }
}