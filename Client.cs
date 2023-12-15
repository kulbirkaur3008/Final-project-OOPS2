using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class Client : Person
    {
        public string MemberId { get; set; }
        public Client() : base() { }    
    }
}
