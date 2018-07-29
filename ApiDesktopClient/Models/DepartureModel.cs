using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesktopClient.Models
{
    public class DepartureModel
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public DateTime DepartureDate { get; set; }
        public int CrewId { get; set; }
        public int AirCraftId { get; set; }
    }
}
