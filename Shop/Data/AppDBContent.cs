using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Shop.Data
{
    public class AppDBContent:DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options):base(options)
        {

        }
    }
}
