﻿using Localiza.Frotas.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Localiza.Frotas.Controllers
{
    [Route("api/v1/[controller]")] //boa pratica indicar qual versao da api
    [ApiController]
    public class VeiculosController : ControllerBase
    {

        private readonly IVeiculoRepository veiculoRepository;
        private readonly IVeiculoDetran veiculoDetran;

        public VeiculosController(IVeiculoRepository veiculoRepository, IVeiculoDetran veiculoDetran)
        {
            this.veiculoRepository = veiculoRepository;
        }

        [HttpGet]
        public IActionResult Get() => Ok(veiculoRepository.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(Guid id) {

            var veiculo = veiculoRepository.GetById(id);
            if (veiculo == null) { return NotFound(); }
            return Ok(veiculo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Veiculo veiculo) {
            veiculoRepository.Add(veiculo);
            return CreatedAtAction(nameof(Get), new { id = veiculo.Id }, veiculo);

        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Veiculo veiculo)
        {
            veiculoRepository.Update(veiculo);
            return NoContent();
        }

        // PUT api/<VeiculosController>/5
        [HttpPut("{id}/vistoria")]
        public IActionResult Put(Guid id)
        {
            veiculoDetran.AgendarVistoriaDetran(id);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var veiculo = veiculoRepository.GetById(id);
            if (veiculo == null) return NotFound();

            veiculoRepository.Delete(veiculo);

            return NoContent();
        }
    }
}
