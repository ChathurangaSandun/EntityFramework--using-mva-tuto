using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_1.Models
{
    public class MusicStoreDataContext:DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }

        public System.Data.Entity.DbSet<new_1.Models.ArtistDetails> ArtistDetails { get; set; }
    }
}
