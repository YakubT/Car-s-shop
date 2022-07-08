using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllcars
    {
        ICarsCategory catcars = new MockCategory();
        public IEnumerable<Car> Cars { 
            get
            {
                return new List<Car>
                {
                    new Car {name = "Ford Fusion hybrid", shortDesc = "Легковий автомобіль, рік 2016", img = "/img/ford_fusion.jpg",price =16000,isFavourite = true,available=true,Category = catcars.AllCategory.ToList<Category>()[2]},
                    new Car {name = "Daewoo Lanos",shortDesc = "Легковий автомобіль, 2007, 1.5л", img = "/img/Lanos.jpg", price =3000, isFavourite = false,Category = catcars.AllCategory.ToList<Category>()[1] }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getobjCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
