using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScanningDoc
{
   public partial class frmSetting : Form
   {
      List<Link> listLink;
      public frmSetting()
      {
         InitializeComponent();
         listLink = new List<Link>();
         listLink.Add(new Link("CV", "E:\\DuLieu\\TaiLieu\\CongVan"));
         listLink.Add(new Link("DA", "E:\\DuLieu\\TaiLieu\\DuAn"));
         gcLink.DataSource = listLink;
      }
   }
}
