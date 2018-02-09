﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter
    {
        //fields
        private int totalPetAmount;
        private int totalPetFeed;
        private int totalVolunteers;
        private int totalEmployees;
        private int totalManagers;

        //Properties
        public int TotalPetAmount { get; set; }
        public int TotalPetFeed { get; set; }
        public int TotalVolunteers { get; set; }
        public int TotalEmployees { get; set; }
        private int TotalManagers { get; set; }

    }
}
