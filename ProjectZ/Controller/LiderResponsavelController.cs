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
    [Route("api/[controller]")]
    [ApiController]
    public class LiderResponsavelController : ControllerBase
    {

        private ILiderResponsavelRepository _repository;

        public LiderResponsavelController(ILiderResponsavelRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("/api/ListAllLeaders")]
        public dynamic ListAllLeaders()
        {
            var leaders = _repository.ListAllLeaders();
            return leaders;
        }
    }
}
