using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Бронь таблица
    /// </summary>
    public class Booking
    {
        public int Id { get; set; }

        public int CatCompId { get; set; }
        public CategoryComputer CategoryComputer { get; set; }

        public DateTime DateTimeBegin { get; set; }
        public DateTime DateTimeEnd { get; set; }

        public int UsersId { get; set; }
        public Users Users { get; set; }

        public bool IsBusy { get; set; }

        public List<FormCheck> FormChecks { get; set; }

    }
}
