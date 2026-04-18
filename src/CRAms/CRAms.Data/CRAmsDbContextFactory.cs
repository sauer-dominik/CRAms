using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace CRAms.Data
{
    public static class CRAmsDbContextFactory
    {
        public static CRAmsDbContext Create(string connectionString)
        {
            var builder = new DbContextOptionsBuilder<CRAmsDbContext>();
            // TODO: Configuration

            return new CRAmsDbContext(builder.Options);
        }
    }
}