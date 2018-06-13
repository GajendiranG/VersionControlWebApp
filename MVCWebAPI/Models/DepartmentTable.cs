using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCWebAPI.Models
{
    public class DepartmentTable
    {
        [Key]
        public int DepNo { get; set; }
        public string DepName { get; set; }
        public string LocationDep { get; set; }
        public List<EmployeeTable> EmployeeTables { get; set; }
    }
}