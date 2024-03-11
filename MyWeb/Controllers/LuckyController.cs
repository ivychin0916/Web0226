using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuckyController : ControllerBase
    {
        // GET: api/LuckyContorller
        [HttpGet]
        public IEnumerable<LuckyModel> Get()
        {
            return new LuckyModel[]
            {
                new LuckyModel(){Id=1,Type = "好運",Content="大吉"}
                , new LuckyModel(){Id=2,Type="普通",Content = "一般"}
            };
        }

        // GET: api/LuckyContorller/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/LuckyContorller
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/LuckyContorller/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/LuckyContorller/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
