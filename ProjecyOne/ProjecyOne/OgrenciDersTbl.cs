using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ProjecyOne
{
    internal class OgrenciDersTbl
    {
        public int id { get; set; }

        public DersTbl DersId { get; set; }

        public OgrenciTbl OgrenciId { get; set; }

    }
}
