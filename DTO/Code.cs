using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanningDoc
{
    public class Code
    {
        private int id;
        private string name;

        public Code(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get {return this.id; } set {this.id = value;} }
        public string Name { get { return this.name; } set { this.name = value; } }
        public override string ToString()
        {
            return Name;
        }
    }
}
