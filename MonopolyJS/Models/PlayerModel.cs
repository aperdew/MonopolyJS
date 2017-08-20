using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonopolyJS.Models
{
    public class PlayerModel
    {
        public List<PropertyModel> propertiesHeld { get; set; }
        public int money { get; set; }
        public int turnOrder { get; set; }
        public bool isHuman { get; set; }
    }
}