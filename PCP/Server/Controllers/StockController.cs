using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PCP.Server.DataAccess;
using PCP.Shared.Models;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PCP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : Controller
    {
        private int cg_cia_usuario = 1; /*CAMBIAR POR LA DEL USUARIO*/

        private readonly AppDbContext _context;
        public StockController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetMaxVale")]
        //public IActionResult GetMaxVale()
        //{
        //    int numero = 1;
        //    try
        //    {
        //        if (_context.Pedidos.Count() > 0)
        //            numero += _context.Pedidos.Where(p => p.CG_CIA == cg_cia_usuario).Max(p => (int)p.VALE);

        //        return Json(numero);
        //    }

        //    catch (Exception EX)
        //    {

        //        throw;
        //    }
        //}
        public async Task<IActionResult> GetMaxVale()
        {
            int numero = 1;
            try
            {
                if (await _context.Pedidos.CountAsync() > 0)
                    numero += await _context.Pedidos.Where(p => p.CG_CIA == cg_cia_usuario).MaxAsync(p => (int)p.VALE);

                return Json(numero);
            }

            catch (Exception EX)
            {

                throw;
            }
        }

        // GET:   
        [HttpGet("GetValesByTipo/{tipoo}")]
        public async Task<ActionResult<IEnumerable<Pedidos>>> GetValesByTipo(int tipoo)
        {
            List<Pedidos> lPedidos = new List<Pedidos>();
            try
            {
                if (_context.Pedidos.Any())
                {
                    lPedidos = await _context.Pedidos.Where(p => p.TIPOO == tipoo && (int)p.VOUCHER == 0
                     && p.CG_CIA == cg_cia_usuario).ToListAsync();
                }

                if (lPedidos == null)
                {
                    return NotFound();
                }

                return lPedidos;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // GET: api/Stock/AbriVale/{vale}
        [HttpGet("AbriVale/{vale}")]
        public async Task<ActionResult<List<Pedidos>>> AbriVale(int vale)
        {
            List<Pedidos> lPedidos = new List<Pedidos>();
            if (_context.Pedidos.Any())
            {
                lPedidos = await _context.Pedidos.Where(p=> p.VALE == vale && p.CG_CIA == cg_cia_usuario).ToListAsync();
            }

            if (lPedidos == null)
            {
                return NotFound();
            }

            return lPedidos;
        }

        //POST: api/Stock
        //To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<List<Producto>>> PostStock(Pedidos pedidos)
        {
            pedidos.USUARIO = "USER";
            pedidos.CG_CIA = 1;

            //if (pedidos?.CG_TIRE == 0  || 
            //    (pedidos.CG_TIRE == 5 && pedidos.CG_PROVE == 0) )
            //{
            //    return BadRequest();
            //}

            //if (pedidos.CG_TIRE == 5 && pedidos.CG_PROVE == 0)
            //{

            //}

            _context.Pedidos.Add(pedidos);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (RegistroExists(pedidos.REGISTRO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            try
            {
                var ret = CreatedAtAction(nameof(AbriVale), new { vale = pedidos.VALE }, pedidos);
                return ret;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private bool RegistroExists(decimal registro)
        {
            return _context.Pedidos.Any(e => e.REGISTRO == registro);
        }
    }
}
