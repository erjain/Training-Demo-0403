#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Training_Demo_0403.Models;

namespace Training_Demo_0403.Data
{
    public class Training_Demo_0403Context : DbContext
    {
        public Training_Demo_0403Context (DbContextOptions<Training_Demo_0403Context> options)
            : base(options)
        {
        }

        public DbSet<Training_Demo_0403.Models.Movie> Movie { get; set; }
    }
}
