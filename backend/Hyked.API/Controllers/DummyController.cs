using Hyked.API.Context;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Hyked.API.Controllers
{
    [ApiController]
    [Route("api/testdb")]
    public class DummyController : ControllerBase
    {
        private readonly HykedContext ctx;

        public DummyController(HykedContext ctx)
        {
            this.ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        [HttpGet]
        public IActionResult TestDatabase()
        {
            return this.Ok();
        }
    }
}
