using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamFinalAsp.Models
{
    public class CarDetails
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public double Price { get; set; }
        public string CarImage { get; set; }

        [ForeignKey("Company")]
        public int Type { get; set; }

        
    }
}
