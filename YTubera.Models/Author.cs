using GenericRepository.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YTubera.Model
{
    [Table("Author")]
    public class Author : Entity<int>
    {
        [Required]
        public string Name { get; set; }
        public string YoutubeUrl { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
