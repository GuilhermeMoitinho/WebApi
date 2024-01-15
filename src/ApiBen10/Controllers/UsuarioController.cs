using Alien.Application.Auth.AuthService;
using Alien.Application.DTO.Request;
using Alien.Application.Interfaces;
using Alien.Application.ServiceResponse;
using Alien.Infrastructure.DataContext;
using Alien.WebAPI.Controllers.Shared;
using Api_Ben10.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceResponse;
using System.Net;

namespace Alien.WebAPI.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UserAppDbContext _context;
        private readonly TokenService _AuthService;

        public UsuarioController(UserAppDbContext context, TokenService authService)
        {
            _context = context;
            _AuthService = authService;
        }

        [HttpPost("cadastro")]
        public async Task<ActionResult<UsuarioCadastroResponse>> Cadastrar(AlienUser usuarioCadastro)
        {
            if (usuarioCadastro is null) return BadRequest();

           await _context.AddAsync(usuarioCadastro); 
           await _context.SaveChangesAsync();

            var tokenUser = _AuthService.GenereteToken(usuarioCadastro);

            var response = new ServicoDeResposta<AlienUser>
            {
                Sucesso = true,
                Dados = usuarioCadastro.Id,
                Mensagem = "Tudo Certo",
                Token = tokenUser
            };

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<UsuarioCadastroResponse>> Login(UsuarioLoginRequest usuarioLogin)
        {
            return Ok();
        }
    }
}