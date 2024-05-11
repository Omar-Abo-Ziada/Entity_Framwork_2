using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTask
{
    [Table("Department")]
    internal class Department
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string? Name { get; set; }

        //------------- Navigating properties -----------------

        public virtual ICollection<School>? Schools { get;}
    }
}
