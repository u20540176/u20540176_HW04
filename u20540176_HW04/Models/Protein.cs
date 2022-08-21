using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20540176_HW04.Models
{
    public class Protein : Food
    {
        public  string MeatType { get; set; } //need a unique attribute

        public Protein() //default constructor
        {

        }
        public Protein(int id,string name,string desc,string pickUp,string meatType):base(id,name,desc,pickUp) //overloaded constructor
        {
            MeatType = meatType;
        }

        public override string getSellDate() 
        {
            return "This " + base.Name + " expires in " + base.getSellDate();
        }

        public override string DisplayFoodGroupType()
        {
            return MeatType;
        }

    }
}