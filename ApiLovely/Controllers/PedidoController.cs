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

        
    }
}