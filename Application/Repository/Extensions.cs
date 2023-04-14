using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Application
{
    public static class Extensions
    {
        public static DbSet<T> CommandSet<T>(this IUnitOfWork context) where T : class
        {
            return context.DetectChangesLazyLoading(true).Set<T>();
        }

        public static IUnitOfWork DetectChangesLazyLoading(this IUnitOfWork context, bool enabled)
        {
            context.ChangeTracker.AutoDetectChangesEnabled = enabled;
            context.ChangeTracker.LazyLoadingEnabled = enabled;
            context.ChangeTracker.QueryTrackingBehavior = enabled ? QueryTrackingBehavior.TrackAll : QueryTrackingBehavior.NoTracking;
            return context;
        }

        public static IQueryable<T> QuerySet<T>(this IUnitOfWork context) where T : class
        {
            return context.DetectChangesLazyLoading(false).Set<T>().AsNoTracking();
        }
    }
}
