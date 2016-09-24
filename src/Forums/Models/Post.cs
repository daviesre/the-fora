using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Forums.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
