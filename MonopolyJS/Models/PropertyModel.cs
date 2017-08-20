using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonopolyJS.Models
{
    public class PropertyModel
    {
        public string Name { get; set; }
        public int Value { get; set; }        
        public int NumOfHouses { get; set; }
        public int NumOfHotels { get; set; }
        public int CostPerHouse { get; set; }
        public int CostPerHotel { get; set; }
        public string Owner { get; set; }
        public int Position { get; set; }
        public int Rent { get; set; }
        public string Color { get; set; }

        //to do: add color, picture, and other info
    }
}