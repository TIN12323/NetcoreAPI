using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HTT1.Models;

namespace HTT1.Data
{
    public class LTQLDb : DbContext
    {
        public LTQLDb (DbContextOptions<LTQLDb> options)
            : base(options)
        {
        }

        public DbSet<LopHoc> LopHoc { get; set; } = default!;
        public DbSet<SinhVien> SinhVien { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
            .HasMany(e => e.SinhVien)
            .WithOne(p => p.LopHoc)
            .HasForeignKey(p =>p.MaLop)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
