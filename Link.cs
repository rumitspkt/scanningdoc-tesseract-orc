using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanningDoc
{
   public class Link
   {
      private string maVB;
      private string duongDan;

      public Link(string maVB, string duongDan)
      {
         this.MaVB = maVB;
         this.DuongDan = duongDan;
      }

      public string MaVB { get => maVB; set => maVB = value; }
      public string DuongDan { get => duongDan; set => duongDan = value; }
   }
}
