using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Forums.Models
{
    public class Topic
    {
        [Key]
        public int TopicId { get; set; }
        [Required(ErrorMessage = "Please enter a topic name.")]
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
