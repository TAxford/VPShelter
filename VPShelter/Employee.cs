using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class Employee
    {
        //fields
        private int employeeID;
        private string employeeName;
        private string employeeType;

        //Properties
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Employeetype { get; set; }

        //Abstract Method
        public abstract int EmpId();
        public abstract string EmpName();
        



    }
}
