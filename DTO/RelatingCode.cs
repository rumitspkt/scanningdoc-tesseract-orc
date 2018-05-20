using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanningDoc.DTO
{
   public class RelatingCode
   {
      private string name;

      public RelatingCode(string name)
      {
         this.name = name;
      }

      public string Name { get => name; set => name = value; }
      public override string ToString()
      {
         return name;
      }
   }
}
