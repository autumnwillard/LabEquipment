using Microsoft.EntityFrameworkCore;
using LabEquipmentAPI.Models;

namespace LabEquipmentAPI.Data
{
    public class LabEquipmentContext : DbContext
    {
        public LabEquipmentContext(DbContextOptions<LabEquipmentContext> options)
            : base(options)
        {
        }

        public DbSet<Equipment> Equipment { get; set; }
    }
}
