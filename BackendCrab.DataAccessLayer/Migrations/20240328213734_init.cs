using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendCrab.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoundationYear = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Address", "CreatedDate", "FoundationYear", "IsDeleted", "Name", "Phone", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Main Street", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7425), 2000, false, "ABC Ltd.", "123-456-7890", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "456 Oak Avenue", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7437), 1995, false, "XYZ Corp.", "987-654-3210", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "789 Elm Street", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7439), 1988, false, "Acme Inc.", "555-123-4567", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "321 Pine Street", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7498), 2005, false, "Global Tech", "555-987-6543", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "555 Cedar Avenue", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7499), 1999, false, "Sunrise Enterprises", "555-222-3333", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "777 Beach Boulevard", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7501), 2010, false, "Oceanic Group", "555-444-5555", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "999 Summit Road", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7502), 1990, false, "Mountain View Inc.", "555-666-7777", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "222 Ridge Street", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7503), 2008, false, "Dynamic Solutions", "555-888-9999", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "444 Summit Avenue", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7504), 2002, false, "Pinnacle Enterprises", "555-000-1111", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "888 Oak Street", new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7505), 1997, false, "Evergreen Technologies", "555-777-8888", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Age", "CompanyId", "CreatedDate", "FirstName", "IsDeleted", "LastName", "Mail", "Phone", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 30, 1, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7715), "John", false, "Doe", "john.doe@abc.com", "111-222-3333", "Software Developer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 35, 1, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7718), "Alice", false, "Smith", "alice.smith@abc.com", "444-555-6666", "HR Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 28, 2, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7720), "Michael", false, "Johnson", "michael.johnson@xyz.com", "777-888-9999", "Sales Representative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 32, 2, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7721), "Emily", false, "Brown", "emily.brown@xyz.com", "222-333-4444", "Marketing Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 40, 3, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7722), "David", false, "Wilson", "david.wilson@def.com", "555-111-2222", "Project Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 27, 3, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7724), "Emma", false, "Johnson", "emma.johnson@def.com", "555-333-4444", "Financial Analyst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 35, 4, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7725), "Christopher", false, "Miller", "christopher.miller@ghi.com", "555-555-6666", "Sales Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 25, 4, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7727), "Sophia", false, "Davis", "sophia.davis@ghi.com", "555-777-8888", "Customer Service Representative", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 38, 5, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7728), "Matthew", false, "Taylor", "matthew.taylor@jkl.com", "555-999-0000", "Product Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 29, 5, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7730), "Olivia", false, "Anderson", "olivia.anderson@jkl.com", "555-222-3333", "Marketing Coordinator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 33, 6, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7731), "Daniel", false, "Thomas", "daniel.thomas@mno.com", "555-444-5555", "IT Specialist", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 31, 6, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7733), "Ava", false, "White", "ava.white@mno.com", "555-666-7777", "Operations Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 36, 7, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7734), "William", false, "Martinez", "william.martinez@pqr.com", "555-888-9999", "HR Coordinator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 26, 7, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7735), "Mia", false, "Garcia", "mia.garcia@pqr.com", "555-000-1111", "Accountant", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 29, 8, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7737), "James", false, "Hernandez", "james.hernandez@stu.com", "555-222-3333", "Software Engineer", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 24, 8, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7738), "Charlotte", false, "Lopez", "charlotte.lopez@stu.com", "555-444-5555", "QA Tester", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 34, 9, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7740), "Benjamin", false, "Gonzalez", "benjamin.gonzalez@vwx.com", "555-666-7777", "Financial Analyst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 27, 9, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7741), "Amelia", false, "Rodriguez", "amelia.rodriguez@vwx.com", "555-888-9999", "Marketing Specialist", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 37, 10, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7742), "Ethan", false, "Smith", "ethan.smith@yz.com", "555-111-2222", "IT Manager", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 32, 10, new DateTime(2024, 3, 29, 0, 37, 33, 880, DateTimeKind.Local).AddTicks(7744), "Isabella", false, "Lee", "isabella.lee@yz.com", "555-333-4444", "HR Director", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                table: "Employee",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
