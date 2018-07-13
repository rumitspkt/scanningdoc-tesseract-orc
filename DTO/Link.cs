using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanningDoc
{
    public class Link
    {
        private Code code;
        private Path path;

        public Link(Code code, Path path)
        {
            this.Code = code;
            this.Path = path;
        }

        public Code Code { get {return this.code;} set {this.code = value;}}
        public Path Path { get { return this.path; } set { this.path = value; } }
    }
}
