using ApiExample.DataAccess.Interfaces;
using ApiExample.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ApiExample.DataAccess.DbContext
{
    public class Context : Microsoft.EntityFrameworkCore.DbContext, IContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<UserRto> Users { get; set; }
        public DbSet<NoteRto> Notes { get; set; }
    }
}
