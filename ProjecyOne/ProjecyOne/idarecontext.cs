using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjecyOne
{
    internal class idarecontext:DbContext
    {
        public DbSet<OgrenciTbl> ogrenciTbls { get; set; }

        public DbSet<OkulYonetimtbl> OkulYonetimtbls { get; set; }

        public DbSet<DersTbl> Derstbls { get; set; }

        public DbSet<OgrenciDersTbl> OgrenciDersTbls { get; set; }

        public idarecontext() : base("idareSistem")
        {


        }

    }
}
