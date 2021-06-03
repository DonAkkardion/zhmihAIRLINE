using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboboKitchenProject.DAL.Impl
{
   public class DataContext : DbContext
    {
        DataContext(DbContextOptions<DbContext> options) : base(options)
            {

            }
    }
}
