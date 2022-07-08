using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }
        [Display(Name = "Введіть ім'я")]
        [StringLength(25)]
        [Required(ErrorMessage ="Довжина ім'я більше 25 символів")]
        public string name { get; set; }
        [Display(Name = "Введіть прізвише")]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина прізвища не більше 30 символів")]
        public string surname { get; set; }
        [Display(Name = "Введіть номер телефону")]
        [StringLength(30)]
        [Required(ErrorMessage = "Довжина телефону не більше 30 символів")]
        public string phone { get; set; }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }
        public List<OrderDetail> orderDetails { get; set; }

    }
}
