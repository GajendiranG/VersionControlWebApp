using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebAPI.Models
{
    public class EmployeeTable
    {
        [Key]
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Desiation { get; set; }
        
        public int DepNo { get; set; }
        
        public int Manager { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        [ForeignKey("DepNo")]
        public List<DepartmentTable> Departments { get; set; }
    }
}