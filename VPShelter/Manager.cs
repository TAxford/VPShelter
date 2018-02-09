using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee
    {
        //Properties
        public bool AdoptPet { get; set; }

        //Constructor
        public Manager()
            {
            //default constructor
            }

        public Manager(int employeeID, string employeeName, string manager)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Employeetype = manager;
        }

        //Override Method
        public override int EmpId()
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
