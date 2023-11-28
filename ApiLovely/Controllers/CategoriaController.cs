using System;
using System.Collections.Generic;
using System.Diagnostics;
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
     public class CategoriaController : ControllerBase
    
    {
        private readonly ILogger<CategoriaController> _logger;

        private readonly ApiLovelyContext _context;

        public CategoriaController(ILogger<CategoriaController> logger, ApiLovelyContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
