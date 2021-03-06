﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VacationsUnited.Data.Enums;

namespace VacationsUnited.Data
{
    public class Itinerary
    {
        [Key]
        public int ItineraryID { get; set; } //unique key
        public Guid OwnerID { get; set; }
        public int GroupID { get; set; }
        public Regions Region { get; set; }
        public DateTimeOffset ItineraryDate {get; set;}
        public string ItineraryName { get; set; }
    }
}