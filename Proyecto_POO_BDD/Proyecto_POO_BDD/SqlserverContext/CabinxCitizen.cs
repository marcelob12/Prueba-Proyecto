using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlserverContext
{
    public partial class CabinxCitizen
    {
        public string Dui { get; set; }
        public int IdCabin { get; set; }

        public virtual Citizen DuiNavigation { get; set; }
        public virtual Cabin IdCabinNavigation { get; set; }
    }
}
