using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlogElena.Models
{
    public class BlogElenaContext : DbContext
    {
        public BlogElenaContext (DbContextOptions<BlogElenaContext> options)
            : base(options)
        {
        }

        public DbSet<BlogElena.Models.BlogPost> BlogPost { get; set; }
    }
}
