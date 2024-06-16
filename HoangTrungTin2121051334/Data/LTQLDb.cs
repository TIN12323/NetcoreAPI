using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoangTrungTin2121051334.Models;

namespace HoangTrungTin2121051334.Data
{
    public class LTQLDb : DbContext
    {
        public LTQLDb (DbContextOptions<LTQLDb> options)
            : base(options)
        {
        }

        public DbSet<LopHoc> LopHoc { get; set; } 
    }
}
