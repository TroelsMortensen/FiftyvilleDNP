using Fiftyville.Model;
using Microsoft.EntityFrameworkCore;

namespace Fiftyville.DataAccess
{
    public class FiftyVilleContext : DbContext
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<AtmTransaction> AtmTransactions { get; set; }
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<CourtHouseSecurityLog> CourtHouseSecurityLogs { get; set; }
        public DbSet<CrimeSceneReport> CrimeSceneReports { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Interview> Interviews { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PhoneCall> PhoneCalls { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // name of database
            // optionsBuilder.UseSqlite(@"Data Source = C:\TRMO\.NET projects\Fiftyville\Fiftyville\fiftyville.db");
            optionsBuilder.UseSqlite(@"Data Source = fiftyville.db");
        }
    }
}