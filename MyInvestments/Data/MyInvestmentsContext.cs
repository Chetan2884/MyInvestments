using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyInvestments.Common;
using MyInvestments.Models;

namespace MyInvestments.Data
{
    public class MyInvestmentsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("appSettings.json");
            IConfiguration configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:" + Constants.MyInvestmentsConn]);
        }

        public DbSet<Login> Logins { get; set; }

        public DbSet<InvestmentTypes> InvestmentTypes { get; set; }

        public DbSet<CompanyMaster> CompanyMaster { get; set; }

        public DbSet<CompanyTypesMaster> CompanyTypesMaster { get; set; }

        public DbSet<CompanyTypesMapping> CompanyTypesMapping { get; set; }

        public DbSet<MutualFundSchemeTypesMaster> MutualFundSchemeTypesMaster { get; set; }

        public DbSet<DepositInvestments> DepositInvestments { get; set; }
    }
}
