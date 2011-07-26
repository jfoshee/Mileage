using System.Data.Entity;

namespace Mileage.Models
{
    public class MileageDB : DbContext
    {
        public IDbSet<Trip> Trips { get; set; }
    }
}
