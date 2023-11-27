using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLovely.Model;
using ApiLovely.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ApiLovely.Controllers
{  
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    
    {
        private readonly ILogger<PedidoController> _logger;

        private readonly ApiLovelyContext _context;

        public PedidoController(ILogger<PedidoController> logger, ApiLovelyContext context)
        {
            _logger = logger;
            _context = context;
        }

    [HttpGet]

        public ActionResult<IEnumerable<Pedido>> Get()
        {
                var pedidos = _context.Pedidos.ToList();
                if(pedidos is null)
                    return NotFound();
                    
                return pedidos;
        }
    [HttpGet ("(id:int)", Name="GetPedido")]

        public ActionResult<Pedido> Get(int id)
        {
            var pedido = _context.Pedidos.FirstOrDefault(p=> p.Id ==id);
                if(pedido is null)
                    return NotFound("Pedido não encontrado.");
                return pedido;
        }
    [HttpPost]
        public ActionResult Post(Pedido pedido){
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            return new CreatedAtRouteResult("Pedido",
                new{ id = pedido.Id},
                pedido);
    }
    [HttpPut ("id:int")]
        public ActionResult Put(int id, Pedido pedido){
            if(id != pedido.Id)
                return BadRequest();

            _context.Entry(pedido).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(pedido);
        
    }
    [HttpDelete]
    public ActionResult Delete(int id){
        var pedido = _context.Pedidos.FirstOrDefault(p=> p.Id == id);

        if(pedido is null)
            return NotFound();
        _context.Pedidos.Remove(pedido);
        _context.SaveChanges();

        return Ok(pedido);
    }
    
    }
}