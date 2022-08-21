using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20540176_HW04.Models
{
    public class Fruit : Food
    {
        public  string FruitType { get; set; }

        public Fruit()
        {

        }

        public Fruit(int id, string name, string desc, string pickUp, string fruitType) : base(id, name, desc, pickUp)
        {
            FruitType = fruitType;
        }

        public override string getSellDate()
        {
            return "This " + base.Name + " expires in " + base.getSellDate();
        }

        public override string DisplayFoodGroupType()
        {
            return FruitType;
        }
    }
}