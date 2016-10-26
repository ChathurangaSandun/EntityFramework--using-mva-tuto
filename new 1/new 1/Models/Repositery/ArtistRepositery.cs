using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_1.Models.Repositery
{
    public class ArtistRepositery: Repositery<Artist>
    {

        public List<Artist> GetBbyName(string name)
        {
            return DbSet.Where(s => s.Name.Contains(name)).ToList();

        }

    }
}
