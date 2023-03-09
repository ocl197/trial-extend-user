using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using trial_extend_user.Models;
using static System.Net.Mime.MediaTypeNames;

namespace trial_extend_user.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<Farm>().HasData(
			   new Farm
			   {
				   ID = 1,
				   FarmName= "Olivers Farm",
				   OwnerId = "2b9659af-daee-4b19-9678-6249fc5f9a42",
				   SubscriptionStatus = "Paid",

				   
			   }
			   );
			builder.Entity<Cow>().HasData(
			   new Cow
			   {
				   Id = 2,
				   FarmId = 1,
				   TagNo = 2323,
				   Breed = "Brown",
				   CowName = "Oliver",
				   FatherTag = "2323",
				   



			   }
			   ); ;

		}
		public DbSet<Farm> Farms { get; set; }
		public DbSet<Cow> Cows { get; set; }
	}
}