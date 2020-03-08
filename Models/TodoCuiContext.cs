using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationTest01._03.Models
{
    using Microsoft.EntityFrameworkCore;

    namespace TodoApi.Models
    {
        public class TodoCuiContext : DbContext
        {
            public TodoCuiContext(DbContextOptions<TodoCuiContext> options)
                : base(options)
            {
            }

            public DbSet<CuiRequest> CuiItem{ get; set; }
        }
    }
}
