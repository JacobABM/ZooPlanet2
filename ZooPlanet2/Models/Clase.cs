using System;
using System.Collections.Generic;

#nullable disable

namespace ZooPlanet2.Models
{
    public partial class Clase
    {
        public Clase()
        {
            Especies = new HashSet<Especy>();
            //Clases = new HashSet<Clase>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Especy> Especies { get; set; }
        //public virtual ICollection<Clase> Clases { get; set; }
    }
}
