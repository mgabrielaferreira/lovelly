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
    public class ProdutoController : ControllerBase
    
    {
        private readonly ILogger<ProdutoController> _logger;

        private readonly ApiLovelyContext _context;

        public ProdutoController(ILogger<ProdutoController> logger, ApiLovelyContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Produto>> Get()
        {
                var produtos = _context.Produtos.ToList();
                if(produtos is null)
                    return NotFound();
                    
                return produtos;
        }
        [HttpGet ("(id:int)", Name="GetPedido")]

        public ActionResult<Produto> Get(int id)
        {
            var produto = _context.Produtos.FirstOrDefault(p=> p.ProdutoId ==id);
                if(produto is null)
                    return NotFound("Produto não encontrado no estoque.");
                return produto;
        }
        [HttpPost]
        public ActionResult Post(Produto produto){
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return new CreatedAtRouteResult("Produtos",
                new{ id = produto.ProdutoId},
                produto);
        }

        [HttpPut ("id:int")]
        public ActionResult Put(int id, Produto produto){
            if(id != produto.ProdutoId)
                return BadRequest();

            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(produto);
        
    }
        [HttpDelete]
        public ActionResult Delete(int id){
            var produto = _context.Produtos.FirstOrDefault(p=> p.ProdutoId == id);

            if(produto is null)
                return NotFound();
            _context.Produtos.Remove(produto);
            _context.SaveChanges();

            return Ok(produto);
        }

    }
}