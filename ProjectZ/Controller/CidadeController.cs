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
    public class CidadeController : ControllerBase
    {

        private ICidadeRepository _repository;

        public CidadeController(ICidadeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("/api/ListAllCities")]
        public dynamic ListAllCities()
        {
            var cidades = _repository.ListAllCities();
            return cidades;
        }
    }
}
