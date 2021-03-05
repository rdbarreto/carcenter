using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_CarCenter.Models;
using System;

namespace API_CarCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly CarCenterContext _context;



        public ClienteController(CarCenterContext  context )
        {

            _context = context;
        }
      
        //get

        [HttpGet("/ListarClientes")]

        public async Task<List<ThCliente>> Get() {

            return await _context.ThClientes.ToListAsync();

        }


        [HttpGet("/ListarCliente/{id}")]

        public async Task<ThCliente> GetbyId(Int32 id)
        {
                      

            return await _context.ThClientes.FirstOrDefaultAsync(x => x.IdCliente == id);

        }


        //post  

        [HttpPost("/CrearCliente")]

        public async Task<ActionResult> Post([FromBody] ThCliente entity) {

            try
            {
                await _context.ThClientes.AddAsync(entity);
                await _context.SaveChangesAsync();
                return new CreatedAtRouteResult("GetbyId", new
                {
                    id = entity.IdCliente,
                    entity
                });

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //put


        [HttpPut("/ActualizarCliente/{id}")]
        public async Task<ActionResult> put(Int32 id, [FromBody] ThCliente valor) {


            try
            {
                if (id != valor.IdCliente) {

                    return BadRequest();
                }

                _context.Entry(valor).State = EntityState.Modified;
                await _context.SaveChangesAsync();
                return Ok();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //delete
        [HttpDelete("/EliminarCliente/{id}")]

        public async Task<ActionResult<ThCliente>> delete(Int32 id) {

            try
            {
                var cliente = await _context.ThClientes.FirstOrDefaultAsync(c => c.IdCliente == id);
                if (cliente == null)
                {
                    return NotFound();
                }
                _context.ThClientes.Remove(cliente);
                await _context.SaveChangesAsync();
                return cliente;
            }
            catch (Exception  ex)
            {

                throw ex;
            }
        
        }


    }
}
