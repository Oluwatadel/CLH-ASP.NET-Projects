﻿namespace BlogApp.Entities
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}
