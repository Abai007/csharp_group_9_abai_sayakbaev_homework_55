
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpDateDate { get; set; }
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrendId { get; set; }
        public Brend Brend { get; set; }
    }
}
