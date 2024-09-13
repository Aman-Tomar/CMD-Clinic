using Microsoft.EntityFrameworkCore;
using CMD.DummyAPI.Model;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace CMD.DummyAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<ClinicAddress> ClinicAddresses { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Clinic>().HasData(
                new Clinic
                {
                    Id = 1,
                    Name = "Fortis Hospital",
                    PhoneNumber = "08066214444",
                    Email = "contact@fortisindia.com",
                    Status = "Active"
                },
                new Clinic
                {
                    Id = 2,
                    Name = "Apollo Hospital",
                    PhoneNumber = "18605007788",
                    Email = "info@apollohospitals.com",
                    Status = "Active"
                },
                new Clinic
                {
                    Id = 3,
                    Name = "AIIMS Delhi",
                    PhoneNumber = "01126588500",
                    Email = "info@aiimsdelhi.edu",
                    Status = "Active"
                },
                new Clinic
                {
                    Id = 4,
                    Name = "Max Healthcare",
                    PhoneNumber = "01142550000",
                    Email = "info@maxhealthcare.com",
                    Status = "Active"
                },
                new Clinic
                {
                    Id = 5,
                    Name = "Manipal Hospitals",
                    PhoneNumber = "08025681818",
                    Email = "contact@manipalhospitals.com",
                    Status = "Active"
                }
            );

            modelBuilder.Entity<ClinicAddress>().HasData(
                new ClinicAddress
                {
                    ClinicAddressId = 1,
                    ClinicId = 1,
                    Street = "Sector 62, Phase 8",
                    City = "Mohali",
                    State = "Punjab",
                    Country = "India",
                    ZipCode = "160062",
                    Location = "30.7046° N, 76.7179° E"
                },
                new ClinicAddress
                {
                    ClinicAddressId = 2,
                    ClinicId = 2,
                    Street = "Greams Road",
                    City = "Chennai",
                    State = "Tamil Nadu",
                    Country = "India",
                    ZipCode = "600006",
                    Location = "13.0827° N, 80.2707° E"
                },
                new ClinicAddress
                {
                    ClinicAddressId = 3,
                    ClinicId = 3,
                    Street = "Ansari Nagar",
                    City = "New Delhi",
                    State = "Delhi",
                    Country = "India",
                    ZipCode = "110029",
                    Location = "28.5672° N, 77.2100° E"
                },
                new ClinicAddress
                {
                    ClinicAddressId = 4,
                    ClinicId = 4,
                    Street = "Press Enclave Road",
                    City = "New Delhi",
                    State = "Delhi",
                    Country = "India",
                    ZipCode = "110048",
                    Location = "28.5496° N, 77.2130° E"
                },
                new ClinicAddress
                {
                    ClinicAddressId = 5,
                    ClinicId = 5,
                    Street = "Old Airport Road",
                    City = "Bengaluru",
                    State = "Karnataka",
                    Country = "India",
                    ZipCode = "560017",
                    Location = "12.9584° N, 77.6144° E"
                }
            );

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = 1,
                    DepartmentName = "Cardiology"
                },
                new Department
                {
                    DepartmentId = 2,
                    DepartmentName = "Pediatrics"
                },
                new Department
                {
                    DepartmentId = 3,
                    DepartmentName = "Orthopedics"
                },
                new Department
                {
                    DepartmentId = 4,
                    DepartmentName = "Neurology"
                },
                new Department
                {
                    DepartmentId = 5,
                    DepartmentName = "Gastroenterology"
                },
                new Department
                {
                    DepartmentId = 6,
                    DepartmentName = "Oncology"
                },
                new Department
                {
                    DepartmentId = 7,
                    DepartmentName = "Dermatology"
                },
                new Department
                {
                    DepartmentId = 8,
                    DepartmentName = "Urology"
                },
                new Department
                {
                    DepartmentId = 9,
                    DepartmentName = "Rheumatology"
                }
            );
        }
    }
}
