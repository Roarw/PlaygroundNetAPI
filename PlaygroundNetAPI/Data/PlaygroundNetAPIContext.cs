using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlaygroundNetAPI.Models;

namespace PlaygroundNetAPI.Data
{
    public class PlaygroundNetAPIContext : DbContext
    {
        public PlaygroundNetAPIContext (DbContextOptions<PlaygroundNetAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PlaygroundNetAPI.Models.RawIngredient> RawIngredient { get; set; } = default!;

        public DbSet<PlaygroundNetAPI.Models.Recipe>? Recipe { get; set; }
    }
}
