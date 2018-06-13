using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebAPI.Models
{
    public class CRUDoperation
    {
        public List<EmployeeTable> getData()
        {
            EmpTableContext dbContext = new EmpTableContext();
            return dbContext.EmployeeTables.ToList();
        }
    }
}