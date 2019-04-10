﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationsUnited.Models.SelectedDestination
{
    public class SelectedDestinationDetail
    {
        public int SelectedDestinationID { get; set; }
        public int Day { get; set; }
        public int ItineraryID { get; set; } //Foreign key
        public int DestinationID { get; set; } //Foreign key
    }
}
