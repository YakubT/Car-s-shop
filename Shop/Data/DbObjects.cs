using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
namespace Shop.Data
{
    public class DbObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { name = "Ford Fusion hybrid", shortDesc = "Легковий автомобіль, рік 2016", img = "/img/ford_fusion.jpg", price = 16000, isFavourite = true, available = true, Category = Categories["Гібридне авто"]},
                    new Car { name = "Daewoo Lanos", shortDesc = "Легковий автомобіль, 2007, 1.5л", img = "/img/Lanos.jpg", price = 3000, isFavourite = false, Category = Categories["Класичні авто"] },
                    new Car { name = "Nissan Leaf", shortDesc = "Легковий автомобіль, 2010, 1.5л", img = "/img/leaf.jpg", price =10000, isFavourite = true, Category = Categories["Електромобілі"] }

                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string,Category> Categories
        {
            get
            {
                if (category==null)
                {
                    var list = new Category[]
                    {
                    new Category {categoryName = "Електромобілі", desc = "Сучасний вид транспорту"},
                    new Category {categoryName = "Класичні авто", desc = "Авто з двигуном внутрішнього згорання"},
                    new Category {categoryName = "Гібридне авто", desc = "Вид транспорту, що поєднує дві технології"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName,el);
                }
                return category;
            }
        }
    }
}
