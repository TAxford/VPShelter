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
        public string Feed { get; set; }
        public string Water { get; set; }

        public Volunteer()
        {
            //default constructor
        }

        public Volunteer(int employeeID, string employeeName, string helper)
        {
            EmployeeID = employeeID;
            EmployeeName = employeeName;
            Employeetype = helper;
        }

       
        //Methods
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

        public string FeedPet(string value)
        {
            Feed = value;
            return "Fed all pets";

        }

        public string WaterPet(string value)
        {
            Water = value;
            return "Watered all pets";
        }
       

    }
}
