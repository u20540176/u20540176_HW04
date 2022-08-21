using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20540176_HW04.Models
{
    public class Carbs:Food
    {
        public string CarbType { get; set; }

        public Carbs()
        {

        }

        public Carbs(int id, string name, string desc, string pickUp, string carbType) : base(id, name, desc, pickUp)
        {
            CarbType = carbType;
        }

        public override string getSellDate()
        {
            return "This " + base.Name + " expires in " + base.getSellDate();
        }

        public override string DisplayFoodGroupType()
        {
            return CarbType;
        }
    }

   



}