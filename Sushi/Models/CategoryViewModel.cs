using System.Collections.Generic;

namespace Sushi.Models
{
    public class CategoryViewModel
    {
        public List<Category> categories { get; set; }
        public List<Production> productions { get; set; }
    }
}