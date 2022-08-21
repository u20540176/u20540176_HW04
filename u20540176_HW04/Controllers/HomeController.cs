using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20540176_HW04.Models; // add directive

namespace u20540176_HW04.Controllers
{
    public class HomeController : Controller
    { //create new list object 
        public static List<Food> foods = new List<Food>();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listings()
        {
            return View(foods); //return list to Listings view
        }

        [HttpGet]
        public ActionResult UploadFood()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFood(string name,int type,string desc,DateTime sellBy,string pickUp,string meatType,string carbType,string vegType,string fruitType,string dairyType)
        {
            //create new protein instance and add to list 
            if(type == 1)
            {
                Protein newProtein = new Protein()
                {
                    Name = name,
                    Description = desc,
                    sellByDate = sellBy,
                    PickUpLocation = pickUp,
                    MeatType = meatType// fix issue, displays 1 and not the words
                };
                foods.Add(newProtein);
            }
            // create new carb instance and add to list
            else if(type == 2)
            {
                Carbs newCarb = new Carbs()
                {
                    Name = name,
                    Description = desc,
                    sellByDate = sellBy,
                    PickUpLocation = pickUp,
                    CarbType = carbType
                };
                foods.Add(newCarb);
            }
            //create new veg instance and add to list
            else if(type == 3)
            {
                Vegetables newVeg = new Vegetables()
                {
                    Name = name,
                    Description = desc,
                    sellByDate = sellBy,
                    PickUpLocation = pickUp,
                    VegType = vegType
                };
                foods.Add(newVeg);
            }
            //create new fruit instance and add to list
            else if (type == 4)
            {
                Fruit newFruit = new Fruit()
                {
                    Name = name,
                    Description = desc,
                    sellByDate = sellBy,
                    PickUpLocation = pickUp,
                    FruitType = fruitType
                };
                foods.Add(newFruit);
            }
            //create new dairy instance and add to list
            else if (type == 5)
            {
                Dairy newDairy = new Dairy()
                {
                    Name = name,
                    Description = desc,
                    sellByDate = sellBy,
                    PickUpLocation = pickUp,
                    DairyType = dairyType
                };
                foods.Add(newDairy);
            }
            return RedirectToAction("Listings");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}