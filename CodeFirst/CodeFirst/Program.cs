using Microsoft.EntityFrameworkCore;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            var emps = context.Employees
                .Include(e => e.Department)
                .ToList();

            //var emps = context.Employees
            //    .Select(e => new
            //    {
            //        e.Name, e.Department.ID
            //    })
            //    .ToList();

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Department.Name);
            }
        }
    }
}