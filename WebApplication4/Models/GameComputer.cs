using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Данная сущность описывает какие игры есть на определенных компьютерах
    /// </summary>
    public class GameComputer
    {
        public int Id { get; set; }

        public int ComputerId { get; set; }
        public Computer Computer { get; set; }


        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
