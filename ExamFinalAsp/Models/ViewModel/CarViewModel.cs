using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamFinalAsp.Models.ViewModel
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public double Price { get; set; }
        public string CarImage { get; set; }
        public string Type { get; set; }
    }
}
