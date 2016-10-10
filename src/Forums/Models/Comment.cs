using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Forums.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public string UserName { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }

        public Comment(string text, string userName, int id = 0)
        {
            Text = text;
            UserName = userName;
            CommentId = id;
        }
        public Comment() { }
    }
}
