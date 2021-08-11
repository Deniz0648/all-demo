using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IlkMvc.Entities;

namespace IlkMvc.Entities
{
    public class News
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public Category Category { get; set; }
    }
}
