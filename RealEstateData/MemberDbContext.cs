using System.Data.Entity;

namespace RealEstateData
{
    public class MemberDbContext : DbContext
    {
        public DbSet<Member> Member { get; set; }
    }
}
