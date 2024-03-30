using BackendCrab.EntityLayer.Entitites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCrab.DataAccessLayer.Seeds
{
    public class EmployeeSeed : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Title = "Software Developer", Mail = "john.doe@abc.com", Phone = "111-222-3333", Age = 30, CompanyId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 2, FirstName = "Alice", LastName = "Smith", Title = "HR Manager", Mail = "alice.smith@abc.com", Phone = "444-555-6666", Age = 35, CompanyId = 1, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 3, FirstName = "Michael", LastName = "Johnson", Title = "Sales Representative", Mail = "michael.johnson@xyz.com", Phone = "777-888-9999", Age = 28, CompanyId = 2, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 4, FirstName = "Emily", LastName = "Brown", Title = "Marketing Manager", Mail = "emily.brown@xyz.com", Phone = "222-333-4444", Age = 32, CompanyId = 2, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 5, FirstName = "David", LastName = "Wilson", Title = "Project Manager", Mail = "david.wilson@def.com", Phone = "555-111-2222", Age = 40, CompanyId = 3, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 6, FirstName = "Emma", LastName = "Johnson", Title = "Financial Analyst", Mail = "emma.johnson@def.com", Phone = "555-333-4444", Age = 27, CompanyId = 3, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 7, FirstName = "Christopher", LastName = "Miller", Title = "Sales Manager", Mail = "christopher.miller@ghi.com", Phone = "555-555-6666", Age = 35, CompanyId = 4, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 8, FirstName = "Sophia", LastName = "Davis", Title = "Customer Service Representative", Mail = "sophia.davis@ghi.com", Phone = "555-777-8888", Age = 25, CompanyId = 4, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 9, FirstName = "Matthew", LastName = "Taylor", Title = "Product Manager", Mail = "matthew.taylor@jkl.com", Phone = "555-999-0000", Age = 38, CompanyId = 5, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 10, FirstName = "Olivia", LastName = "Anderson", Title = "Marketing Coordinator", Mail = "olivia.anderson@jkl.com", Phone = "555-222-3333", Age = 29, CompanyId = 5, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 11, FirstName = "Daniel", LastName = "Thomas", Title = "IT Specialist", Mail = "daniel.thomas@mno.com", Phone = "555-444-5555", Age = 33, CompanyId = 6, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 12, FirstName = "Ava", LastName = "White", Title = "Operations Manager", Mail = "ava.white@mno.com", Phone = "555-666-7777", Age = 31, CompanyId = 6, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 13, FirstName = "William", LastName = "Martinez", Title = "HR Coordinator", Mail = "william.martinez@pqr.com", Phone = "555-888-9999", Age = 36, CompanyId = 7, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 14, FirstName = "Mia", LastName = "Garcia", Title = "Accountant", Mail = "mia.garcia@pqr.com", Phone = "555-000-1111", Age = 26, CompanyId = 7, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 15, FirstName = "James", LastName = "Hernandez", Title = "Software Engineer", Mail = "james.hernandez@stu.com", Phone = "555-222-3333", Age = 29, CompanyId = 8, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 16, FirstName = "Charlotte", LastName = "Lopez", Title = "QA Tester", Mail = "charlotte.lopez@stu.com", Phone = "555-444-5555", Age = 24, CompanyId = 8, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 17, FirstName = "Benjamin", LastName = "Gonzalez", Title = "Financial Analyst", Mail = "benjamin.gonzalez@vwx.com", Phone = "555-666-7777", Age = 34, CompanyId = 9, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 18, FirstName = "Amelia", LastName = "Rodriguez", Title = "Marketing Specialist", Mail = "amelia.rodriguez@vwx.com", Phone = "555-888-9999", Age = 27, CompanyId = 9, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 19, FirstName = "Ethan", LastName = "Smith", Title = "IT Manager", Mail = "ethan.smith@yz.com", Phone = "555-111-2222", Age = 37, CompanyId = 10, CreatedDate = DateTime.Now, IsDeleted = false },
                new Employee { Id = 20, FirstName = "Isabella", LastName = "Lee", Title = "HR Director", Mail = "isabella.lee@yz.com", Phone = "555-333-4444", Age = 32, CompanyId = 10, CreatedDate = DateTime.Now, IsDeleted = false }
            );
        }
    }
}
