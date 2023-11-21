using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace ApiLovely.Model
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Id { get; set; }
        public int Email { get; set; }

    }
}