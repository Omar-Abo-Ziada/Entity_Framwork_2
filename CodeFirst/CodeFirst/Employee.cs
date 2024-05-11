using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    [Table("Employee")]
    internal class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public Department Department { get; set; }

    }
}
