using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EFGetVerses
{
    class FavoriteVersesContext: DbContext
    {
        public DbSet<Favorites> Favorites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\versefavorites.db");
    }

    public class Favorites
    {
        public string Id { get; set; }
        public string Verse { get; set; }
        public string ImageLink { get; set; }
    }
}
