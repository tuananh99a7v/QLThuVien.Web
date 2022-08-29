using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.Model
{
    public class QLThuVienDbContext : IdentityDbContext
    {

        public static QLThuVienDbContext Create()
        {
            return new QLThuVienDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
        }
    }
}
