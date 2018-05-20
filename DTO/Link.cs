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

        public Code Code { get => code; set => code = value; }
        public Path Path { get => path; set => path = value; }
    }
}
