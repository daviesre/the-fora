using Forums.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forums.ViewModels
{
    public class CommentsViewModel
    {
        public Post post { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
    }
}
