using homework_52.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homework_52.ViewModel
{
    public class BrandAndCompanyViewModel
    {
        public Product Product { get; set; }
        public List<Brend> BrendList { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}
