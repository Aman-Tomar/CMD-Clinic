using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CMD.DummyAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "ClinicAddresses",
                columns: table => new
                {
                    ClinicAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClinicId = table.Column<int>(type: "int", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    State = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicAddresses", x => x.ClinicAddressId);
                    table.ForeignKey(
                        name: "FK_ClinicAddresses_Clinics_ClinicId",
                        column: x => x.ClinicId,
                        principalTable: "Clinics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clinics",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { 1, "contact@fortisindia.com", "Fortis Hospital", "08066214444", "Active" },
                    { 2, "info@apollohospitals.com", "Apollo Hospital", "18605007788", "Active" },
                    { 3, "info@aiimsdelhi.edu", "AIIMS Delhi", "01126588500", "Active" },
                    { 4, "info@maxhealthcare.com", "Max Healthcare", "01142550000", "Active" },
                    { 5, "contact@manipalhospitals.com", "Manipal Hospitals", "08025681818", "Active" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Cardiology" },
                    { 2, "Pediatrics" },
                    { 3, "Orthopedics" },
                    { 4, "Neurology" },
                    { 5, "Gastroenterology" },
                    { 6, "Oncology" },
                    { 7, "Dermatology" },
                    { 8, "Urology" },
                    { 9, "Rheumatology" }
                });

            migrationBuilder.InsertData(
                table: "ClinicAddresses",
                columns: new[] { "ClinicAddressId", "City", "ClinicId", "Country", "Location", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Mohali", 1, "India", "30.7046° N, 76.7179° E", "Punjab", "Sector 62, Phase 8", "160062" },
                    { 2, "Chennai", 2, "India", "13.0827° N, 80.2707° E", "Tamil Nadu", "Greams Road", "600006" },
                    { 3, "New Delhi", 3, "India", "28.5672° N, 77.2100° E", "Delhi", "Ansari Nagar", "110029" },
                    { 4, "New Delhi", 4, "India", "28.5496° N, 77.2130° E", "Delhi", "Press Enclave Road", "110048" },
                    { 5, "Bengaluru", 5, "India", "12.9584° N, 77.6144° E", "Karnataka", "Old Airport Road", "560017" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClinicAddresses_ClinicId",
                table: "ClinicAddresses",
                column: "ClinicId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClinicAddresses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Clinics");
        }
    }
}
