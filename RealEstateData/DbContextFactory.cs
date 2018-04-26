using System;

namespace RealEstateData
{
    public class DbContextFactory : IDbContextFactory, IDisposable
    {
        private readonly Lazy<EstateDbContext> _context = new Lazy<EstateDbContext>(() => new EstateDbContext());
        private readonly Lazy<MemberDbContext> _contextM = new Lazy<MemberDbContext>(() => new MemberDbContext());
        public EstateDbContext Context
        {
            get { return _context.Value; }
        }
        public MemberDbContext ContextM
        {
            get { return _contextM.Value; }
        }

        public void Dispose()
        {
            if (_context.IsValueCreated && _contextM.IsValueCreated)
            {
                Context.Dispose();
                ContextM.Dispose();
            }
        }

    }
}
