using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Subject(string name, string code) { Name = name; Code = code; }
        public Subject(string name) : this(name, "N/A") { }
        public override string ToString() => $"{Name} ({Code})";
    }

}
