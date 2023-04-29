using Estadio.API.Data;
using Estadio.Shared.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estadio.API.Controllers
{
    [ApiController]
    [Route("/api/boletas")]

    public class BoletasController : Controller
    {

        private readonly DataContext _context;

        public BoletasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.Boletas.ToListAsync());
        }

        [HttpGet("{id:int}")]  //buscar por id
        public async Task<ActionResult> GetAsync(int id)
        {
            var boleta = await _context.Boletas.FirstOrDefaultAsync(x => x.Id == id);
            if (boleta == null)
            {
                return NotFound();
            }

            return Ok(boleta);
        }

        [HttpPost]  //ingresar boletas
        public async Task<ActionResult> PostAsync(Boleta boleta)
        {
            _context.Add(boleta);
            await _context.SaveChangesAsync();
            return Ok(boleta);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Boleta boleta)
        {
            _context.Update(boleta);
            await _context.SaveChangesAsync();
            return Ok(boleta);
        }


    }
}



    



