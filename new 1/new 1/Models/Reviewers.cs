using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_1.Models
{
    public class Reviewers
    {

        [Key]
        
        public int  ReviwerID { get; set; }
        public string Name { get; set; }

        public virtual List<Album> Albums { get; set; }
    }
}
