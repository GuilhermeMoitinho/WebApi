using Alien.Application.Auth.AuthService;
using Alien.Application.DTO.Request;
using Alien.Application.Interfaces;
using Alien.Application.ServiceResponse;
using Alien.Infrastructure.DataContext;
using Alien.WebAPI.Controllers.Shared;
using Api_Ben10.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceResponse;
using System.ComponentModel;
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
        public async Task<ActionResult> Cadastrar(AlienUser usuarioCadastro)
        {
            if (usuarioCadastro is null) return BadRequest();

           await _context.AddAsync(usuarioCadastro); 
           await _context.SaveChangesAsync();

            var response = new ServicoDeResposta<AlienUser>
            {
                Sucesso = true,
                Dados = usuarioCadastro.Id,
                Mensagem = "Tudo Certo",
                Token = "Efetue o login para receber seu token!"
            };

            return Ok(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login(AlienUser usuarioLogin)
        {
            if (usuarioLogin is null) return NotFound();

            var tokenUser = _AuthService.GenereteToken(usuarioLogin);

            var UsuarioExiste = await _context.User.FirstOrDefaultAsync(userLambda => userLambda.Email == usuarioLogin.Email && userLambda.Password == usuarioLogin.Password);

            if (UsuarioExiste == null) return NotFound();

            var response = new ServicoDeResposta<AlienUser>
            {
                Sucesso = true,
                Dados = usuarioLogin.Id,
                Mensagem = "Tudo Certo",
                Token = tokenUser
            };

            return Ok(response);
        }
    }
}