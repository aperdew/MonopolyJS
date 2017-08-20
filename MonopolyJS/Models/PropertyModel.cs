using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonopolyJS.Models
{
    public class PropertyModel
    {
        public int value { get; set; }
        public string name { get; set; }
        public int numOfHouses { get; set; }
        public int numOfHotels { get; set; }
        public int costPerHouse { get; set; }
        public int costPerHotel { get; set; }
        public string owner { get; set; }
        //to do: add color, picture, and other info
    }
}