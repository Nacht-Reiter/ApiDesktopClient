using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesktopClient.Models
{
    public class FlightModel
    {
        public int Id { get; set; }
        public string EntryPoint { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public IEnumerable<int> TicketsId { get; set; }
    }
}
