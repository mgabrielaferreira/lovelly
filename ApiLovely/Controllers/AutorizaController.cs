using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiLovely.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace ApiLovely.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AutorizaController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AutorizaController(UserManager<identityUser> userManager,
        SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
    }
}