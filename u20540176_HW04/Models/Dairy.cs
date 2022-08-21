using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20540176_HW04.Models
{
    public class Dairy: Food
    {
        public string DairyType { get; set; }

        public Dairy()
        {

        }

        public Dairy(int id, string name, string desc, string pickUp, string dairyType) : base(id, name, desc, pickUp)
        {
            DairyType = dairyType;
        }

        public override string getSellDate()
        {
            return "This " + base.Name + " expires in " + base.getSellDate();
        }

        public override string DisplayFoodGroupType()
        {
            return DairyType;
        }
    }
}