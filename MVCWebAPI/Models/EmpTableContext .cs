using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCWebAPI.Models
{
    public class EmpTableContext:DbContext
    {
        public DbSet<DepartmentTable> DepartmentTables { get; set; }
        public DbSet<EmployeeTable> EmployeeTables { get; set; }
    }
}