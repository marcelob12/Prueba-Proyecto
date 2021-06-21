using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlserverContext
{
    public partial class Register
    {
        public int Id { get; set; }
        public DateTime? DateCabine { get; set; }
        public int? IdManager { get; set; }
        public int? IdCabin { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Manager IdManagerNavigation { get; set; }
    }
}
