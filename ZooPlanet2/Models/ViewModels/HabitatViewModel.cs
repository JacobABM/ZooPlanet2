using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZooPlanet2.Models.ViewModels
{
    public class HabitatViewModel
    {
        public IEnumerable<Especy> Habitats { get; set; }
        public IEnumerable<Especy> Especies { get; set; }
    }
}
