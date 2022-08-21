using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20540176_HW04.Models
{ //encapsulation shown through the derived classes as they can only be accessed through the food base class
    public abstract class Food
    {   //get and set data members 
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string PickUpLocation { get; set; }

        public DateTime currentDate = DateTime.Now;

        public DateTime sellByDate { get; set; }

        public Food() //default constructor
        {

        }

        public Food(int id, string name, string desc, string pickUp ) //overloaded constructor
        {
            ID = id;
            Name = name;
            Description = desc;
            PickUpLocation = pickUp;
        }

        public virtual string getSellDate() //virtual method
        {
            return ((sellByDate.Date - currentDate.Date).Days).ToString() + " days";
        }

        public abstract string DisplayFoodGroupType(); //abstract method
        

        


    }
}