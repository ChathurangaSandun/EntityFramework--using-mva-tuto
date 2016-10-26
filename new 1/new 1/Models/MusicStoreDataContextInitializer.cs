using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_1.Models
{
    class MusicStoreDataContextInitializer : DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            Artist artist = new Artist() {Name = "first name"};
            context.Artists.Add(artist);

            context.Albums.Add(new Album() {Title = "first album", Artist = artist});
            context.Albums.Add(
                new Album()
                {
                    Title = "second album",
                    Artist = context.Artists.Add(new Artist() {Name = "three name"})
                });
                 

            context.SaveChanges();
        }
    }
}
