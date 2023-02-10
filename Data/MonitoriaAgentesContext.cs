using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MonitoriaAgentes.Models;

namespace MonitoriaAgentes.Data
{
    public class MonitoriaAgentesContext : DbContext
    {
        public MonitoriaAgentesContext (DbContextOptions<MonitoriaAgentesContext> options)
            : base(options)
        {
        }

        public DbSet<MonitoriaAgentes.Models.Monitoria> Monitoria { get; set; } = default!;
    }
}
