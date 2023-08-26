using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ACapp.Models;

    public class ACAPPContext : DbContext
    {

        public ACAPPContext (DbContextOptions<ACAPPContext> options)
            : base(options)
        {
        }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User_Input>().ToTable(tb => tb.HasTrigger("calculate_costf"));
    }
    public DbSet<ACapp.Models.Device> Device { get; set; } = default!;

        public DbSet<ACapp.Models.User_Input> User_Input { get; set; } = default!;

        public DbSet<ACapp.Models.Quote_Input> Quote_Input { get; set; } = default!;
    }
