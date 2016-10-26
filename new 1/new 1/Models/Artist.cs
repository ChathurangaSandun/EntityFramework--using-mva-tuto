using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace new_1.Models
{
    [Table(name:"Artist")]
    public class Artist
    {
        public int ArtistID { get; set; }

        [Required]
        [StringLength(120),MaxLength(150)]
        public string Name { get; set; }


        public virtual List<Album> Albums { get; set; }
        public virtual ArtistDetails ArtistDetails{ get; set; }


    }
}
