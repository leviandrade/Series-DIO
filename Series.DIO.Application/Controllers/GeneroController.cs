using Microsoft.AspNetCore.Mvc;
using Series.DIO.Domain.Interfaces.Services;
using Series.DIO.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Series.DIO.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : Controller
    {
        private readonly IGeneroService _generoService;

        public GeneroController(IGeneroService generoService)
        {
            _generoService = generoService;
        }


        [HttpPost]
        public async Task<IActionResult> Salvar([FromBody] GeneroModel genero)
        {
            await _generoService.Inserir(genero);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] GeneroModel genero)
        {
            await _generoService.Atualizar(genero);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir([FromRoute] int id)
        {
            await _generoService.Excluir(id);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GeneroModel>>> Listar()
        {
            var users = await _generoService.Listar();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GeneroModel>> ConsultarPorId([FromRoute] int id)
        {
            var genero = await _generoService.ConsultarPorId(id);
            return Ok(genero);
        }
    }
}
