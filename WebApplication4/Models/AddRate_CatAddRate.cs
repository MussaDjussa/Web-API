using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Категория определенных дополнительных услуг, а также их цена и скидка
    /// </summary>
    public class AddRate_CatAddRate
    {
        public int Id { get; set; }


        public int AddRateId { get; set; }
        public AddRate AddRate { get; set; }

        public int CategoryAddId { get; set; }
        public CategoryAddRate CategoryAddRate { get; set; }

        public double Price { get; set; }

        public int DiscountId { get; set; }
        public TypeDiscount TypeDiscount { get; set; }
    }
}
