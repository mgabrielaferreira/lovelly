using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ApiLovely.Model;
using ApiLovely.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Windows.Markup;

namespace ApiLovely.Controllers
{  
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    
    {
        private readonly ILogger<ClienteController> _logger;

        private readonly ApiLovelyContext _context;

        public ClienteController(ILogger<ClienteController> logger, ApiLovelyContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Cliente>> Get()
        {
                var clientes = _context.Clientes.ToList();
                if(clientes is null)
                    return NotFound();
                    
                return clientes;}

    [HttpGet ("(id:int)", Name="GetCliente")]

    public ActionResult<Cliente> Get(int id)
    {
        var cliente = _context.Clientes.FirstOrderDefault(PageActionEndpointConventionBuilder => p.Id ==id);
            if(cliente is null)
                return NotFound("Cliente não encontrado.");
            return cliente;
    }

    [HttpPost]
    public ActionResult Post(Cliente cliente){
        _context.Clientes.Add(cliente);
        _context.SaveChanges();

        return new CreatedAtRouteResult("GetCliente",
            new{ id = cliente.Id},
            cliente);
    }

    [HttpPut ("id:int")]
    public ActionResult Put(int id, Cliente cliente){
        if(id != cliente.Id)
            return BadRequest();

        _context.Entry(cliente).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(cliente);
    
    }
    [HttpDelete]
    public ActionResult Delete(int id){
        var cliente = _context.Clientes.FirstOrderDefault(p=> p.Id == id);

        if(cliente is null)
            return NotFound();
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();

        return Ok(cliente);
    }
    }
}