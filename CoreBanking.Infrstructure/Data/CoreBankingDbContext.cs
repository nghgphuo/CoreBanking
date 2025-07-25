﻿using CoreBanking.Infrstructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreBanking.Infrstructure.Data
{ 
    public class CoreBankingDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } = default!;
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Transaction> Transactions { get; set; } = default!;

        public CoreBankingDbContext() 
        { 
        }
        public CoreBankingDbContext(DbContextOptions<CoreBankingDbContext> options) : base(options)
        {
        }
    }
}
