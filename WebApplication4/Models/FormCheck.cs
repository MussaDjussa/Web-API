using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Чек, договор между клубом и клиентом
    /// </summary>
    public class FormCheck
    {
        public int Id { get; set; }

        public DateTime DateRate { get; set; } = DateTime.UtcNow;

        public int RateId { get; set; }
        public Rate Rate { get; set; }


        public int PayId { get; set; }
        public TypePay TypaPay { get; set; }

        public int CatCompId { get; set; }
        public CategoryComputer CategoryComputer { get; set; }


        public int AddRateId { get; set; }
        public AddRate AddRate { get; set; }


        public int ClientId { get; set; }
        public Users Users { get; set; }

        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        
        public bool isEarly { get; set; }
        public string Description { get; set; }
    }
}
