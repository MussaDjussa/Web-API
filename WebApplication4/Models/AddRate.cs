using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Дополнительные услуги
    /// </summary>
    public class AddRate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<FormCheck> FormChecks { get; set; }

        public List<AddRate_CatAddRate> AddRate_CatAddRates { get; set; }

    }
}
