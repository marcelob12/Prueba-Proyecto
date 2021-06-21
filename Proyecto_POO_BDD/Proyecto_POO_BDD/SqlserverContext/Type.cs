using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlserverContext
{
    public partial class Type
    {
        public Type()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string TypeEmployee { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
