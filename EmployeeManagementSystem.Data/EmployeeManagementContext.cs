using System.Data.Entity;

namespace EmployeeManagementSystem.Data
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Data.Entity.DbContext" />
    /// <remarks>

    /// </remarks>
    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}