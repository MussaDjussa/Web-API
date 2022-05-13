using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{

    /// <summary>
    /// Запись остаточных часов клиента, ссылается на чек/договор
    /// </summary>
    public class History
    {
        public int Id { get; set; }

        public DateTime DateTimeHistory { get; set; } = DateTime.UtcNow;

        public int Remain { get; set; }

        public List<FormCheck> FormCheckId { get; set; }


    }
}
