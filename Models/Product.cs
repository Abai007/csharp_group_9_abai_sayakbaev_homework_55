
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace homework_55.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Укажите название товара")]
        [StringLength (100, MinimumLength = 3, ErrorMessage = "Название товара должна быть от трех символов!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Укажите стоимость товара")]
        [Remote(action: "CheckPrice", controller:"Products", ErrorMessage ="Стоимость товара должна быть выше \"50\"")]
        public int Price { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpDateDate { get; set; }
        [Required(ErrorMessage = "Добавьте фото товара")]
        public string Image { get; set; }


        public ImageModel ImageModel { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrendId { get; set; }
        public Brend Brend { get; set; }
    }
}
