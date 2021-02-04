using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private DataContext _context;
        public WeatherForecastController(DataContext context)
        {
            this._context=context;
        }
       

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
          var values= await _context.Values.ToListAsync();
          return Ok(values);
        }
        
        [HttpGet("{id}")]
         public async Task<ActionResult<IEnumerable<Value>>> Get(int id)
        {
          var value= await _context.Values.FindAsync(id);
          return Ok(value);
        }
    }
}
