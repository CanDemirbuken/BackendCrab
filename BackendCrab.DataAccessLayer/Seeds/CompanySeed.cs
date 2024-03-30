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
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                new Company
                {
                    Id = 1,
                    Name = "ABC Ltd.",
                    Address = "123 Main Street",
                    Phone = "123-456-7890",
                    FoundationYear = 2000,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 2,
                    Name = "XYZ Corp.",
                    Address = "456 Oak Avenue",
                    Phone = "987-654-3210",
                    FoundationYear = 1995,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 3,
                    Name = "Acme Inc.",
                    Address = "789 Elm Street",
                    Phone = "555-123-4567",
                    FoundationYear = 1988,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 4,
                    Name = "Global Tech",
                    Address = "321 Pine Street",
                    Phone = "555-987-6543",
                    FoundationYear = 2005,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 5,
                    Name = "Sunrise Enterprises",
                    Address = "555 Cedar Avenue",
                    Phone = "555-222-3333",
                    FoundationYear = 1999,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 6,
                    Name = "Oceanic Group",
                    Address = "777 Beach Boulevard",
                    Phone = "555-444-5555",
                    FoundationYear = 2010,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 7,
                    Name = "Mountain View Inc.",
                    Address = "999 Summit Road",
                    Phone = "555-666-7777",
                    FoundationYear = 1990,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 8,
                    Name = "Dynamic Solutions",
                    Address = "222 Ridge Street",
                    Phone = "555-888-9999",
                    FoundationYear = 2008,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 9,
                    Name = "Pinnacle Enterprises",
                    Address = "444 Summit Avenue",
                    Phone = "555-000-1111",
                    FoundationYear = 2002,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Company
                {
                    Id = 10,
                    Name = "Evergreen Technologies",
                    Address = "888 Oak Street",
                    Phone = "555-777-8888",
                    FoundationYear = 1997,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
