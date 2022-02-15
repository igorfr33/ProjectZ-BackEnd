// =============================================================================
// ApplicationContext.cs
// 
// Autor  : Igor Fernandes Rabelo
// Data   : 17/01/2022
// =============================================================================
using Microsoft.EntityFrameworkCore;
using ProjectZ.Model;

namespace ProjectZ.Data
{
    //Classe de Contexto de banco de dados
    public class ApplicationContext : DbContext
    {
        #region Propriedades Públicas
        //Váriavel com o valor da Model carregando seus atributos
        public DbSet<CidadeModel> cidade{ get; set; }
        public DbSet<LiderResponsavelModel> lider_resposavel{ get; set; }
        public DbSet<PessoasCaptadasModel> pessoas_captadas{ get; set; }
        public DbSet<SolicitacaoModel> solicitacao{ get; set; }
        public DbSet<ListaPresencaModel> lista_presenca{ get; set; }
        #endregion

        #region Construtores
        public ApplicationContext( DbContextOptions<ApplicationContext> options ) : base( options )
        {
        }
        #endregion

        #region Métodos/Operadores Protegidos
        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.Entity<CidadeModel>().Property( p => p.Nome_Cidade ).HasMaxLength( 100 );
            modelBuilder.Entity<CidadeModel>().Property( p => p.Nome_Estado ).HasMaxLength( 100 );
            modelBuilder.Entity<CidadeModel>().Property( p => p.Nome_Lider ).HasMaxLength( 100 );

            modelBuilder.Entity<LiderResponsavelModel>().Property( p => p.Nome_Cidade ).HasMaxLength( 100 );
            modelBuilder.Entity<LiderResponsavelModel>().Property( p => p.Nome_Estado ).HasMaxLength( 100 );
            modelBuilder.Entity<LiderResponsavelModel>().Property( p => p.Nome_Lider ).HasMaxLength( 100 );

            modelBuilder.Entity<SolicitacaoModel>().Property( p => p.Nome_Cidade ).HasMaxLength( 100 );
            modelBuilder.Entity<SolicitacaoModel>().Property( p => p.Nome_Estado ).HasMaxLength( 100 );
            modelBuilder.Entity<SolicitacaoModel>().Property( p => p.Nome_Lider ).HasMaxLength( 100 );
            modelBuilder.Entity<SolicitacaoModel>().Property( p => p.Solicitante ).HasMaxLength( 100 );
        }
        #endregion
    }
}