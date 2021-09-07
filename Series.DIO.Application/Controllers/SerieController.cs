using Microsoft.AspNetCore.Mvc;
using Series.DIO.Domain.Interfaces.Services;
using Series.DIO.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Series.DIO.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : Controller
    {
        private readonly ISerieService _serieService;

        public SerieController(ISerieService serieService)
        {
            _serieService = serieService;
        }


        [HttpPost]
        public async Task<IActionResult> Salvar([FromBody] SerieModel serie)
        {
            await _serieService.Inserir(serie);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Atualizar([FromBody] SerieModel serie)
        {
            await _serieService.Atualizar(serie);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir([FromRoute] int id)
        {
            await _serieService.Excluir(id);

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SerieModel>>> Listar()
        {
            var users = await _serieService.Listar();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SerieModel>> ConsultarPorId([FromRoute] int id)
        {
            var serie = await _serieService.ConsultarPorId(id);
            return Ok(serie);
        }
    }
}
