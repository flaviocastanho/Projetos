using System;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Dominio;
using EFCore.Repo;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IEFCoreRepository _repo;

        public ClienteController(IEFCoreRepository repo)
        {
            _repo = repo;
        }

        // GET: api/Cliente
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var cliente = await _repo.GetAllClientes();
                if (cliente != null)
                {
                    return Ok(cliente);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }

            return BadRequest($"Nenhum registro encontrado");
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "GetCliente")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cliente = await _repo.GetClienteById(id);
                if (cliente != null)
                {
                    return Ok(cliente);
                }

            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }

            return BadRequest($"Registro não encontrado");
        }

        // POST: api/Cliente
        [HttpPost]
        public async Task<IActionResult> Post(Cliente model)
        {
            try
            {
                _repo.Add(model);

                if (await _repo.SaveChangeAsync())
                {
                    return Ok("Cadastrado com Sucesso");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }

            return BadRequest($"Registro não inserido");
        }


        // PUT: api/Cliente/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Cliente model)
        {
            try
            {
                var cliente = await _repo.GetClienteById(id);
                if (cliente != null)
                {
                    _repo.Update(model);

                    if (await _repo.SaveChangeAsync())
                        return Ok("Atualizado com Sucesso");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }

            return BadRequest($"Registro não atualizado");
        }

        // DELETE: api/Cliente/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _repo.GetClienteById(id);
                if (cliente != null)
                {
                    _repo.Delete(cliente);

                    if (await _repo.SaveChangeAsync())
                        return Ok("Registro deletado com sucesso");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex}");
            }

            return BadRequest($"Registro não deletado");
        }
    }
}
