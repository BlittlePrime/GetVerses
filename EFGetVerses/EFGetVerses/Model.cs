using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFGetVerses
{
    class VersesContext: DbContext
    {
        public DbSet<Favorites> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\versefavorites.db");
    }

    public class Favorites
    {
        public string Id { get; set; }
        public string verse { get; set; }
        public string imageLink { get; set; }
    }
}
