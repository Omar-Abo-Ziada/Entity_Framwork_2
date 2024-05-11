using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTask
{
    [Table("School")]
    internal class School
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(50) , Required]
        public string Name { get; set; }

        [MaxLength(50)]
        public string? Type { get; set; }

        [ForeignKey("Department")]
        public int? DepartmentID { get; set; }

        //------------- Navigating properties -----------------

        public virtual Department? Department { get; set; }

        public virtual ICollection<Teacher>? Teachers { get; set; }

        [InverseProperty("FromSchool")]
        public virtual ICollection<TeacherTransfer>? MovingFrom { get; set; }

        [InverseProperty("ToSchool")]
        public virtual ICollection<TeacherTransfer>? CommingTo { get; set; }

    }
}
