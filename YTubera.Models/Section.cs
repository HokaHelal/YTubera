using GenericRepository.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YTubera.Model
{
    [Table("Section")]
    public class Section : Entity<int>
    {
        [Required]
        public string Name { get; set; }
        public int Order { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
