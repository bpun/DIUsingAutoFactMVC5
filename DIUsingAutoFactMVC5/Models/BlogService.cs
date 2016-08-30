using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DIUsingAutoFactMVC5.Models
{
    public class BlogService:IServiceBlog
    {
        public Blog GetBlog()
        {
            Blog blog = new Blog();
            blog.PostList = new List<Post>
            {
                new Post {Title="First",Content="My First Post" },
                 new Post {Title="Second",Content="My Second Post" },
                 new Post {Title="Third",Content="My Third Post" },
                 new Post {Title="Fourth",Content="My Fourth Post" }
            };
            return blog;
        }
    }
}