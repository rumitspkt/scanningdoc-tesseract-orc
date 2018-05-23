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
      public static frmSetting setting = null;
      public static frmAdvancedSetting advancedSetting = null;
      public static frmProcessing processing = null;
      public frmMain()
      {
         InitializeComponent();
         RemoveFormCloseButton();
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
            frmMain.setting = f;
            f.MdiParent = this;
            f.Show();
         }
      }

      internal void setBtnEnable(bool check)
      {
         btnExit.Enabled = check;
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
         frmMain.processing = f;
         f.MdiParent = this;
         f.ControlBox = false;
         f.Show();
      }

      private void btnAdvancedSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form frm = this.checkExisted(typeof(frmAdvancedSetting));
         if (frm != null)
         {
            frm.Activate();
         }
         else
         {
            frmAdvancedSetting f = new frmAdvancedSetting();
            frmMain.advancedSetting = f;
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         this.Close();
      }
      private void RemoveFormCloseButton()
      {
         DevExpress.Skins.Skin currentSkin;
         DevExpress.Skins.SkinElement elementFormButtonClose;

         currentSkin = DevExpress.Skins.FormSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default);
         elementFormButtonClose = currentSkin[DevExpress.Skins.FormSkins.SkinFormButtonClose];
         elementFormButtonClose.Image.Image = null;
         elementFormButtonClose.Glyph.Image = null;
      }

      private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         frmTesting f = new frmTesting();
         f.Show();
      }
   }
}
