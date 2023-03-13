using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace api.Model
{
    public class Author 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        
        [JsonIgnore]
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
