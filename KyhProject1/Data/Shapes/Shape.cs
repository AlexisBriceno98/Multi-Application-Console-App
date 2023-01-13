using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace KyhProject1.Data.Shapes
{
    public class Shape
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TypeOfShape { get; set; }
        [Required]
        public double Width { get; set; }
        [Required]
        public double Height { get; set; }
        [Required]
        public double Area { get; set; }
        [Required]
        public double Perimeter { get; set; }
        [Required]
        public DateTime Date { get; set; }

    }

}
