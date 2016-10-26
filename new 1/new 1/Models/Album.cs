using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_1.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        [Required()]
        [StringLength(100)]
        public string  Title { get; set; }


        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
