using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCore6CrudOperations.Models;

namespace MVCore6CrudOperations.Data
{
    public class MVCore6CrudOperationsContext : DbContext
    {
        public MVCore6CrudOperationsContext (DbContextOptions<MVCore6CrudOperationsContext> options)
            : base(options)
        {
        }

        public DbSet<MVCore6CrudOperations.Models.Students> Students { get; set; } = default!;
    }
}
