using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Укажите имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Укажите адрес")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Укажите нномер телефона")]
        public string ContactPhone { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
