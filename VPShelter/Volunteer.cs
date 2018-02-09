using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee
    {
        //Properties
        public string Helper { get; set; }

        public Volunteer()
        {
            //default constructor
        }

        public Volunteer(int employeeID, string employeeName, string helper)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Helper = helper;
        }

       

        public  override int EmpId()
        {
           int employeeId = EmployeeID;
           return employeeId;
        }

        public override string EmpName()
        {
            string employeeName = EmployeeName;
            return employeeName;
        }

       

    }
}
