using System;
using System.ComponentModel.DataAnnotations;

namespace Mileage.Models
{
    public class Trip
    {
        public int Id { get; set; }
        [UIHint("number")]
        public int OdometerStart { get; set; }
        [UIHint("number")]
        public int OdometerEnd { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
    }
}
