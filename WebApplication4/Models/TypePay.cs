using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Тип оплаты
    /// </summary>
    public class TypePay
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<FormCheck> FormChecks { get; set; }

    }
}
