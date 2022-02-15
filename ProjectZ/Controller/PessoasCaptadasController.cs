using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProjectZ.Repository.Interface;

namespace ProjectZ.Controller
{
    [ApiController]
    public class PessoasCaptadasController : ControllerBase
    {
        
        private IPessoasCaptadasRepository _repository;

        public PessoasCaptadasController(IPessoasCaptadasRepository repository)
        {
            _repository = repository;
        }

        [HttpGet, Route("/api/ListAll")]
        public dynamic ListAllCities()
        {
            var pessoas = _repository.ListAll();
            return pessoas;
        }
    }
}
