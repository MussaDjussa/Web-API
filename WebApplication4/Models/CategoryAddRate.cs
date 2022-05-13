using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Категории долонительных услуг(еда, напитки, кофе, алкоголь и тд)
    /// </summary>
    public class CategoryAddRate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<AddRate_CatAddRate> AddRate_CatAddRate { get; set; }
    }
}
