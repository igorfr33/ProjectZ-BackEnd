// =============================================================================
// Startup.cs
// 
// Autor  : Igor Fernandes Rabelo
// Data   : 05/01/2022
// =============================================================================

using Microsoft.AspNetCore.Mvc;
using ProjectZ.Repository.Interface;

namespace Operation.Controller
{

    //Classe de Controller responsável por chamar o Repositorio 
    [ApiController]
    [Route("projectz/ListSolicitations")]
    public class SolicitacoesContoller : ControllerBase
    {

        private ISolicitacaoRepository _repository;

        public SolicitacoesContoller(ISolicitacaoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("")]
        public dynamic ListAllSolicitations()
        {
            var solicitations = _repository.ListAllSolicitations();
            return solicitations;
        }
    }
}
