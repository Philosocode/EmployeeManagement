using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Joe",
                    Department = Dept.IT,
                    Email = "joe@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "Steel",
                    Department = Dept.HR,
                    Email = "steele@gmail.com"
                }
            );
        }
    }
}
