using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Тип скидки для дополнительных услуг
    /// </summary>
    public class TypeDiscount
    {
        public int Id { get; set; }

        /// <summary>
        /// 10%, 15%, 20%, 50%,
        /// </summary>
        public string Description { get; set; }

        public double Value { get; set; }

        public List<AddRate_CatAddRate> AddRate_CatAddRate { get; set; }
    }
}
