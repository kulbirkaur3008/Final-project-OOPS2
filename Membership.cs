using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class Membership
    {
        public string MemberNumber { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }

        public Membership() : base() { }

    }
}
