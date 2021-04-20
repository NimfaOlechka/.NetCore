using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebApp.Models
{
    public static class ModelBuilderExtensions
    {
        public static  void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Mary", Department = Department.IT, Email = "mary@test.dk" },
                new Employee() { Id = 2, Name = "John", Department = Department.HR, Email = "john@test.dk" },
                new Employee() { Id = 3, Name = "Sam", Department = Department.HR, Email = "sam@test.dk" },
                new Employee() { Id = 4, Name = "Mary", Department = Department.IT, Email = "mary2@test.dk" },
                new Employee() { Id = 5, Name = "Ben", Department = Department.AR, Email = "ben@test.dk" }
                );
        }
    }
}
