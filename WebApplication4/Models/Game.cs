using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models

{
    /// <summary>
    /// Данная сущность описывает игры для сущности Computer
    /// </summary>
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<GameComputer> GameComputer { get; set; }
    }
}
