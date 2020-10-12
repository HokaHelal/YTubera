using GenericRepository.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YTubera.Model
{
    [Table("Lesson")]
    public class Lesson : Entity<int>
    {
        [Required]
        public string Name { get; set; }
        public int Order { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
