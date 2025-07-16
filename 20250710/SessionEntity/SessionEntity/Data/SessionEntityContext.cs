using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SessionEntity.Models;

namespace SessionEntity.Data
{
    public class SessionEntityContext : DbContext
    {
        public SessionEntityContext (DbContextOptions<SessionEntityContext> options)
            : base(options)
        {
        }

        public DbSet<SessionEntity.Models.Grade> Grade { get; set; } = default!;
        public DbSet<SessionEntity.Models.Student> Student { get; set; } = default!;
    }
}
