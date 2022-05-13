using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    /// <summary>
    /// Компьютеры
    /// </summary>
    public class Computer
    {
        public int Id { get; set; }

        /// <summary>
        /// номер компьютера
        /// </summary>
        public int NumberComp { get; set; }

        public string Processor { get; set; }
        public string VideoCard { get; set; }
        public string Mouse { get; set; }
        public string Keyborad { get; set; }
        public string Headphones { get; set; }
        public string Monitor { get; set; }

        public string PhotoPath { get; set; }

        public List<GameComputer> GameComputers { get; set; }
        public List<CategoryComputer> CategoryComputers { get; set; }

        /// характеристики...
    }
}
