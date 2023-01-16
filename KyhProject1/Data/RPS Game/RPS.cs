using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyhProject1.Data.RPS_Game
{
    public class RPS
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Wins { get; set; }
        public double Losses { get; set; }
        public double Rounds { get; set; }


        public double WinRate
        {
            get { return Wins / Rounds; }
        }

        public double LossRate
        {
            get { return Losses / Rounds; }
        }
    }
}
