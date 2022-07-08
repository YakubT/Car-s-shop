using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using Shop.Data.Models;

namespace Shop.Controllers
{
    public class CarsController:Controller
    {
        private readonly IAllcars allcars;
        private readonly ICarsCategory allcateg;
        public CarsController(IAllcars iallcars, ICarsCategory carsCategory)
        {
            allcars = iallcars;
            allcateg = carsCategory;
        }
        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = allcars.Cars.OrderBy(i => i.id);
                
            }
            else
            {
                if (string.Equals("electro",category,StringComparison.OrdinalIgnoreCase))
                {
                    cars = allcars.Cars.Where(i => i.Category.categoryName.Equals("Електромобілі")).OrderBy(i=>i.id);
                    currCategory = "Електромобілі";
                }
                else
                if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    cars = allcars.Cars.Where(i => i.Category.categoryName.Equals("Класичні авто")).OrderBy(i => i.id);
                    currCategory = "Класичні авто";
                }
                else
                {
                    cars = allcars.Cars.Where(i => i.Category.categoryName.Equals("Гібридне авто")).OrderBy(i => i.id);
                    currCategory = "Гібридні авто";
                }

            }
            
            var carObj = new CarsListViewModel
            {
                AllCars = cars,
                currCategory = currCategory
            };
            ViewBag.Title = "Сторінка з автомобілями";
            return View(carObj);
        }
    }
}
