using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Forums.Models;

namespace Forums.ViewModels
{
    public class PostsViewModel
    {
        public Topic topic { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
