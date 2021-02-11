using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MovieImg { get; set; }
        public string MovieURL { get; set; }
    }
}
