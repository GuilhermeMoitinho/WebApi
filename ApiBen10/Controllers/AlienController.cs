using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBen10.Application.AliensExtensions;
using ApiBen10.Application.DTO;
using ApiBen10.Application.ServiceResponse;
using ApiBen10.Domain.Entities;
using ApiBen10.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiBen10.Controllers
{
    [ApiController]
    [Route("api/aliens")]
    public class AlienController : ControllerBase
    {
        private readonly IAlienApplication _alienapplication;

        public AlienController(IAlienApplication alienapplication)
        {
            _alienapplication = alienapplication;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos(int posicao = 0, int pegar = 5)
        {
            var Aliens = await _alienapplication.ObterTodos(posicao, pegar);
            var servico = new ServicoDeResposta<AlienGetDTO>();
            
            servico.Sucesso = true;
            servico.Dados = Aliens.ParaAliensGetDto();
            servico.Mensagem = "Seus Aliens foram requisitados";

            return Ok(servico);   
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterProdutoPorId(Guid id)
        {
            if(id == Guid.Empty)
                return BadRequest(new ServicoDeResposta<Alien>()
                {
                    Sucesso = false,
                    Dados = null,
                    Mensagem = "Erro na requisicao"
                });

            var AlienId = await _alienapplication.ObterProdutoPorId(id);

            if(AlienId is null) return NotFound();

            var AlienIdDTO = AlienId.ParaAlienGetDTO();

            var retorno = new ServicoDeResposta<Alien>(){
                Sucesso = true,
                Dados = AlienIdDTO,
                Mensagem = "Seu Alien foi requisitado"
            };

            return Ok(retorno);
        }

        [HttpPost]
         public async Task<IActionResult> Adicionar(AlienPostDTO alienPostDto)
         {
             var validarDTO = new AlienPostValidacao().Validate(alienPostDto);

             if(!validarDTO.IsValid)
             {
                var erro = new ServicoDeResposta<Alien>()
                {
                    Sucesso = false,
                    Dados = null,
                    Mensagem = "Erro na requisicao"
                };
                return BadRequest(erro);
             }

             var Alien = alienPostDto.ParaAlienDomainDTO();

             await _alienapplication.Adicionar(Alien);

              var retorno = new ServicoDeResposta<Alien>(){
                Sucesso = true,
                Dados = new {id = Alien.Id},
                Mensagem = "Seu Alien foi adicionado"
            };

            return CreatedAtAction("ObterProdutoPorId", "Alien", new { id = Alien.Id }, retorno);
         }

        [HttpPut("{id}")]
         public async Task<IActionResult> EditarAlien(AlienPostDTO alienPostDto, Guid id)
         {
              if(id == Guid.Empty)
                return BadRequest(new ServicoDeResposta<Alien>()
                {
                    Sucesso = false,
                    Dados = null,
                    Mensagem = "Erro na requisicao"
                });

                var alienEditado = alienPostDto.ParaAlienDomainDTO();
                await _alienapplication.EditarAlien(alienEditado, id);

                return NoContent();   
         }

        [HttpDelete("{id}")]
         public async Task<IActionResult> RemoverAlien(Guid id)
         {
              if(id == Guid.Empty)
                return BadRequest(new ServicoDeResposta<Alien>()
                {
                    Sucesso = false,
                    Dados = null,
                    Mensagem = "Erro na requisicao"
                });

                await _alienapplication.RemoverAlien(id);

                return NoContent();   
         }
        
    }
}