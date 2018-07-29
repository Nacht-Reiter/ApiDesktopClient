using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesktopClient.Models
{
    public class AirCraftTypeModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int PassengersCapacity { get; set; }
        public decimal CargoCapacity { get; set; }
    }
}
