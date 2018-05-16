using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScanningDoc
{
   public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public frmMain()
      {
         InitializeComponent();
      }

      private void btnSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.checkExisted(typeof(frmSetting));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmSetting f = new frmSetting();
            f.MdiParent = this;
            f.Show();
         }
      }
      private Form checkExisted(Type fType)
      {
         foreach (Form f in this.MdiChildren)
         {
            if (f.GetType() == fType)
            {
               return f;
            }
         }
         return null;
      }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmProcessing f = new frmProcessing();
            f.MdiParent = this;
            f.ControlBox = false;
            f.Show();
        }
    }
}
