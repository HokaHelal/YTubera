using GenericRepository.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace YTubera.Model
{
    [Table("Course")]
    public class Course : AuditableEntity<int>
    {       
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public float TotalDuration { get; set; }
        public int Level { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Section> Sections { get; set; }
        public ICollection<CourseAttachment> Attachments { get; set; }

    }
}
