using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlserverContext
{
    public partial class SecondaryEffect
    {
        public SecondaryEffect()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string SecEffect { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
