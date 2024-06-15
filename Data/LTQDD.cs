using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nanh1111kiemtra.Models;

    public class LTQDD : DbContext
    {
        public LTQDD (DbContextOptions<LTQDD> options)
            : base(options)
        {
        }

        public DbSet<nanh1111kiemtra.Models.LopHoc> LopHoc { get; set; } = default!;

        public DbSet<nanh1111kiemtra.Models.SinhVien> SinhVien { get; set; } = default!;
    }
