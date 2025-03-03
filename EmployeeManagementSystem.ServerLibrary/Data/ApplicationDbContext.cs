using EmployeeManagementSystem.BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.ServerLibrary.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<GeneralDepartment> GeneralDepartments { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<Town> Towns { get; set; }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
}