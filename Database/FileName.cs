using Corpa4Sem4.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Corp4Sem4.Database
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User>? Users { get; set; }
        public DbSet<Message>? Messages { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			var options = new
			{
				Server = "localhost:5432",
				Database = "corp4",
				User = "postgres",
				Password = "010201Max",
			};
			optionsBuilder.UseNpgsql($"Server = {options.Server}; Database ={options.Database}; Uid = {options.User}; Pwd = {options.Password};");
		}
    }
}
