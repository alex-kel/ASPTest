using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApp.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreationDate { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public Post()
        {
            CreationDate = DateTime.Now;
        }
    }

}