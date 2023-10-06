﻿using Barbearia.Models;
using Microsoft.EntityFrameworkCore;

namespace Barbearia.BdContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
