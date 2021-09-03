using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homework_55.Models
{
    public class Brend
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Вы не указали название бренда")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Brend()
        {
            Products = new List<Product>();
        }
    }
}
