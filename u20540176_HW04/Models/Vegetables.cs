using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20540176_HW04.Models
{
    public class Vegetables : Food
    {
        public  string VegType { get; set; }

        public Vegetables()
        {

        }

        public Vegetables(int id, string name, string desc, string pickUp, string vegType) : base(id, name, desc, pickUp)
        {
            VegType = vegType;
        }
        public override string getSellDate()
        {
            return "This " + base.Name + " expires in " + base.getSellDate();
        }

        public override string DisplayFoodGroupType()
        {
            return VegType;
        }
    }
}