using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBoletim.Domains;
using APIBoletim.Repositorio;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBoletim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        AlunoRepository repo = new AlunoRepository();

        // GET: api/<AlunoController>
        [HttpGet]
        public List<Aluno> Get()
        {
            return repo.ListarTodos();
        }

        // GET api/<AlunoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlunoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlunoController>/5
        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] Aluno a)
        {
            return repo.Alterar(id, a);
        }

        // DELETE api/<AlunoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repo.Excluir(id);
        }
    }
}
