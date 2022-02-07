using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Column(TypeName ="VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage ="This property is required")]
        [ForeignKey("Genre")]
        public int? GenreId { get; set; }

        [Required]
        public int? Stock { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }
    }
}