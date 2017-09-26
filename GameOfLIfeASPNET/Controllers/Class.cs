using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GameOfLIfeASPNET.Controllers
{
    public class MyController
    {
        [HttpGet("test/greg")]
        public string Greg()
        {
            return "HI!";
        }

        [HttpGet( "test/steve" )]
        public string Steve()
        {
            return "Yo.";
        }
    }
}
