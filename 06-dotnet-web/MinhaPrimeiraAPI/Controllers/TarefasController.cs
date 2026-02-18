using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;

namespace MinhaPrimeiraAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private static List<Tarefa> _tarefas = new List<Tarefa>
        {
            new Tarefa { Id = 1, Descricao = "Aprender ASP.NET Core", Concluida = false },
            new Tarefa { Id = 2, Descricao = "Fazer café", Concluida = true }

        };

        [HttpGet]
        public IActionResult ListarTodas()
        {
            return Ok(_tarefas);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);

            if ( tarefa == null )
            {
                return NotFound();
            }
            return Ok(tarefa);
        }

        [HttpPost] 
        public IActionResult CriarNova([FromBody] Tarefa novaTarefa)
        {
            if (_tarefas.Count > 0)
                novaTarefa.Id = _tarefas.Max(t => t.Id) + 1;
            else
                novaTarefa.Id = 1;

            _tarefas.Add(novaTarefa);

            return CreatedAtAction(nameof(BuscarPorId), new {id = novaTarefa.Id}, novaTarefa);
            
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Tarefa tarefaAtualizada)
        {
            var tarefaExistente = _tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefaExistente == null)
                return NotFound();

            tarefaExistente.Descricao = tarefaAtualizada.Descricao;
            tarefaExistente.Concluida = tarefaAtualizada.Concluida;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefa == null) 
                return NotFound();
            
            return NoContent();
        }
    }
}