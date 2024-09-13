using CMD.DummyAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CMD.DummyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClinicController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClinic()
        {
            return Ok(await context.Clinics.Include(c => c.ClinicAddress).ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetClinicById(int id)
        {
            var clinic = await context.Clinics
                              .Include(c => c.ClinicAddress)
                              .FirstOrDefaultAsync(c => c.Id == id);
            if (clinic == null)
            {
                return NotFound("Clinic not found");
            }

            return Ok(clinic);
        }
    }
}
