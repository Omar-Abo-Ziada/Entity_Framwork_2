using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTask
{
    [Table("teacher")]
    internal class Teacher
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("School")]
        public int? SchoolID { get; set; }

        [MaxLength(50) , Required]
        public string? Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthDate { get; set; }

        [MaxLength(50)]
        public string? NationalID { get; set; }

        [MaxLength(10)]
        public string? Code { get; set; }

        [MaxLength(50)]
        public string? Job { get; set; }

        [MaxLength(15)]
        public string? Phone { get; set; }

        [MaxLength(100)]
        public string? Qualifications { get; set; }

        [Column(TypeName = "date")]
        public DateTime? QualificationDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HiringDate { get; set; }

        public Address? Adress { get; set; }

        [MaxLength(200)]
        public string? Notes { get; set; }

        [ForeignKey("TeacherTransfer")]
        public int? TeacherTtansferID { get; set; }

        //------------- Navigating properties -----------------

        public virtual School? School { get; set; }

        public virtual ICollection<TeacherTransfer>? TeacherTransfer { get; set; }

    }
}
