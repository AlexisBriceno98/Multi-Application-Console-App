﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.RPS_Game
{
    public class RPS
    {
        [Required]
        public int Id { get; set; }
        public string PlayerChoice { get; set; }
        public double Wins { get; set; }
        public double Losses { get; set; }
        public double Rounds { get; set; }
        [Required]
        public double winRate { get; set; }
        public DateTime Date { get; set; }
    }
}
