using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTask
{
    [Table("TeacherTransfer")]
    internal class TeacherTransfer
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Teacher")]
        public int? TeaherID { get; set; }

        [ForeignKey("FromSchool")]
        public int? FromSchoolID { get; set; }

        [ForeignKey("ToSchool")]
        public int? ToSchoolID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }


        //------------- Navigating properties -----------------

        [InverseProperty("MovingFrom")]
        public virtual School? FromSchool { get; set; }

        [InverseProperty("CommingTo")]
        public virtual School? ToSchool { get; set; }

        public virtual Teacher? Teacher { get; set; }

    }
}
