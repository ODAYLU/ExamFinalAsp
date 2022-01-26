using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamFinalAsp.Models.ViewModel;

namespace ExamFinalAsp.Models
{
    public class HRDbContext :DbContext
    {
        public HRDbContext(DbContextOptions<HRDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<CarDetails> Cars { get; set; }
        public DbSet<Company> Companyes { get; set; }
        public DbSet<ExamFinalAsp.Models.ViewModel.CarViewModel> CarViewModel { get; set; }
        public DbSet<ExamFinalAsp.Models.ViewModel.CompanyViewModel> CompanyViewModel { get; set; }
       
    }
}
