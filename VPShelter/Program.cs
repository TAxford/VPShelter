using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            string empType;
            int userChoice =0;
            

            Hippo hippoOne = new Hippo("Christian", 50, 50, 50);
            Hippo hippoTwo = new Hippo("Hayleigh", 40, 30, 70);
            Hippo hippoThree = new Hippo("Chloe", 50, 10, 50);

            Volunteer volunteerOne = new Volunteer(10, "Becca", "Employee");
            Volunteer volunteerTwo = new Volunteer(20, "Pete", "Helper");
            Volunteer volunteerThree = new Volunteer(30, "Daniel", "Helper");

            Manager managerOne = new Manager(1, "Tim", "Owning Manager");

            Volunteer volunteer = new Volunteer();

            Console.WriteLine("Welcome to Hippo Porium. What type of employee are you? Please eneter Manager or Volunteer");
            empType = Console.ReadLine().ToLower();
            if (empType == "manager")
            {

                Console.WriteLine("Thank you for working here at Hippo Porium as the Manager!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Adopt a Hippo");
                Console.WriteLine("2. Feed the Hippos");
                Console.WriteLine("3. Water the Hippos");
                Console.WriteLine("4. Exit");
                userChoice = int.Parse(Console.ReadLine());


                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("You have adopted a Hippo, Great job");
                        break;

                    case 2:
                        Console.WriteLine("You feed all the Hippos" + " yum yum yum yum");
                        break;

                    case 3:
                        Console.WriteLine("You gave all the Hippos freash water" + " splish splash");
                        break;
                    case 4:
                        Console.WriteLine("Thank you for your work and support at Hippo Porium");
                        break;

                }

            }
            else if (empType == "volunteer")
            {
                Console.WriteLine("Thank you for working here at Hippo Porium as a Volunteer!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Play with a Hippo");
                Console.WriteLine("2. Feed the Hippos");
                Console.WriteLine("3. Water the Hippos");
                Console.WriteLine("4. Exit");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("You played catch with a Hippo");
                        break;

                    case 2:
                        Console.WriteLine("You feed all the Hippos" + " yum yum yum yum");
                        break;

                    case 3:
                        Console.WriteLine("You gave all the Hippos freash water" + " splish splash");
                        break;
                    case 4:
                        Console.WriteLine("Thank you for your work and support at Hippo Porium");
                        break;
                }
            }

































        }
    }
}
