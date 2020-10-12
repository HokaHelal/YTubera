using GenericRepository.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YTubera.Model
{
    [Table("CourseAttachment")]
    public class CourseAttachment : AuditableEntity<int>
    {
        [Required]
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
