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
        public async Task<ActionResult<IEnumerable<Stock>>> GetValesByTipo(int tipoo)
        {
            List<Stock> lStock = new List<Stock>();
            try
            {
                if (_context.Pedidos.Any())
                {
                    lStock = await _context.Pedidos.Where(p => p.TIPOO == tipoo && (int)p.VOUCHER == 0
                     && p.CG_CIA == cg_cia_usuario).ToListAsync();
                }

                if (lStock == null)
                {
                    return NotFound();
                }

                return lStock;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        // GET: api/Stock/AbriVale/{vale}
        [HttpGet("AbriVale/{vale}")]
        public async Task<ActionResult<List<Stock>>> AbriVale(int vale)
        {
            List<Stock> lStock = new List<Stock>();
            if (_context.Pedidos.Any())
            {
                lStock = await _context.Pedidos.Where(p=> p.VALE == vale && p.CG_CIA == cg_cia_usuario).ToListAsync();
            }

            if (lStock == null)
            {
                return NotFound();
            }

            return lStock;
        }

        // PUT: api/Stock/PutStock/123729
        [HttpPut("PutStock/{registro}")]
        public async Task<IActionResult> PutStock(decimal registro, Stock stock)
        {
            if (registro != stock.REGISTRO)
            {
                return BadRequest("Registro Incorrecto");
            }

            _context.Entry(stock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistroExists(registro))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(stock);
        }

        //POST: api/Stock
        //To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<List<Producto>>> PostStock(Stock Stock)
        {
            Stock.USUARIO = "USER";
            Stock.CG_CIA = 1;

            //if (Stock?.CG_TIRE == 0  || 
            //    (Stock.CG_TIRE == 5 && Stock.CG_PROVE == 0) )
            //{
            //    return BadRequest();
            //}

            //if (Stock.CG_TIRE == 5 && Stock.CG_PROVE == 0)
            //{

            //}

            _context.Pedidos.Add(Stock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (RegistroExists(Stock.REGISTRO))
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
                var ret = CreatedAtAction(nameof(AbriVale), new { vale = Stock.VALE }, Stock);
                return ret;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private bool RegistroExists(decimal? registro)
        {
            return _context.Pedidos.Any(e => e.REGISTRO == registro);
        }
    }
}
