using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategory
        {
             get
             {
                return new List<Category>
                {
                    new Category {categoryName = "Електромобілі", desc = "Сучасний вид транспорту"},
                    new Category {categoryName = "Класичні авто", desc = "Авто з двигуном внутрішнього згорання"},
                    new Category {categoryName = "Гібриде авто", desc = "Вид транспорту, що поєднує дві технології"}

                };
             }
        }
    }
}
