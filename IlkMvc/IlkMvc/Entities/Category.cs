using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IlkMvc.Entities;

namespace IlkMvc.Entities
{
    public class Category
    {
        public Category()
        {
            News = new HashSet<News>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public ICollection<News> News { get; set; }

    }
}
