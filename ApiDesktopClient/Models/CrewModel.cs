using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDesktopClient.Models
{
    public class CrewModel
    {
        public int Id { get; set; }
        public int PilotId { get; set; }
        public IEnumerable<int> StewardessesId { get; set; }
    }
}
