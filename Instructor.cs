using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Data
{
    public class Instructor : Person
    {
        public string Specialization { get; set; }
        public Instructor() : base() { }
    }
}
