using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjecyOne
{
    internal class DersTbl
    {
        public int id { get; set; }

        public string adsoyad { get; set; }

        public string kredisi { get; set; }

        public OkulYonetimtbl OkulYonetimID { get; set; }

    }
}
