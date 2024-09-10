using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LabEquipmentAPI.Models;
using LabEquipmentAPI.Data;

namespace LabEquipmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {
        private readonly LabEquipmentContext _context;

        public EquipmentController(LabEquipmentContext context)
        {
            _context = context;
        }

        // GET: api/Equipment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Equipment>>> GetEquipment()
        {
            return await _context.Equipment.ToListAsync();
        }
    }
}


