using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuggyController : ControllerBase
    {
        public ApplicationDbContext _Context { get; }
        public BuggyController(ApplicationDbContext context)
        {
            _Context = context;

        }


        [HttpGet("notfound")]
        public IActionResult GetNotFoundRequest()
        {
            var foundProduct = _Context.Products.Find(100);

            return foundProduct == null ? NotFound() : Ok();
        }



    }
}