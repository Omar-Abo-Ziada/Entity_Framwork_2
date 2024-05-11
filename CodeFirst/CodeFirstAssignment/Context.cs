using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment
{
    internal class Context : DbContext
    {
        public Context() : base("Data Source=DESKTOP-2U2SE1A;Initial Catalog=CodeFirstAssignment;Integrated Security=True;")
        {
            
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }

    }
}
