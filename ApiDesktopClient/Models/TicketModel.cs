using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesktopClient.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public int Price { get; set; }
    }
}
