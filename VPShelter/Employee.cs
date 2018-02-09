using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //fields
        private int employeeID;
        

        //Properties
        public int EmployeeID { get; set; }
        

        //Abstract Method
        public abstract void EmployeeType();
        public abstract void EmployeeName();



    }
}
