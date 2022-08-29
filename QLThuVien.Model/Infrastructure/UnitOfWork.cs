using System;
using System.Threading.Tasks;

namespace QLThuVien.Model.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
        void Commit();

        Task CommitAsync();

        void Save();

        Task SaveAsync();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly QLThuVienDbContext _context;

        public UnitOfWork(QLThuVienDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}