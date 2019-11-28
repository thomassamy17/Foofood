using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExempleCours.Models
{
    public class OffreEntite
    {
        public int Id { get; set; }
        [Required]
        [StringLength(256), MinLength(2)]
        public string Titre{ get;set; }
        [Required]
        [StringLength(256), MinLength(2)]
        public string Description { get; set; }
        [Required]
        [StringLength(256), MinLength(2)]
        public string Url { get; set; }
        [Required]
        public int Prix { get; set; }
    }
}
