using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Тарифы (стандарт, ночной, утренний, дневной)
    /// </summary>
    public class Rate
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int PlayTime { get; set; }

        public double Price { get; set; }

        public List<FormCheck> FormChecks { get; set; }
    }
}
