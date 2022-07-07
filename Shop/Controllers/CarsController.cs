using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;

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
        public ViewResult List()
        {
            ViewBag.Title = "Сторінка з автомобілями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = allcars.Cars;
            obj.currCategory = "Автомобілі";
            return View(obj);
        }
    }
}
