using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Данная сущность описывает где клиент хочет находится(стандарт, вип, бильярд, лаунч зона, к примеру)
    /// </summary>
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<CategoryComputer> CategoryComputers { get; set; }
    }
}
