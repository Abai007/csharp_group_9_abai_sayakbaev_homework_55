using homework_55.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_55.ViewModel
{
    public class BrandAndCompanyViewModel
    {
        public Product Product { get; set; }
        public List<Brend> BrendList { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}
