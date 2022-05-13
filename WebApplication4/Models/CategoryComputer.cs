using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Данная сущность описывает игровые зоны, в которых есть определенные компьютеры
    /// </summary>
    public class CategoryComputer
    {
        public int Id { get; set; }

        public int ComputerId { get; set; }
        public Computer Computer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

       
        public List<FormCheck> FormChecks { get; set; }

    }
}
