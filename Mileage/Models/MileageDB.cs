using System.Data.Entity;

namespace Mileage.Models
{
    public class MileageDB : DbContext
    {
        public DbSet<Trip> Trips { get; set; }
    }
}
