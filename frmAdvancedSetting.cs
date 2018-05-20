using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ScanningDoc.DTO;

namespace ScanningDoc
{
   public partial class frmAdvancedSetting : Form
   {
      int id;
      List<RelatingCode> list;
      static List<Code> codes;
      public frmAdvancedSetting()
      {
         InitializeComponent();
      }

      private void frmAdvancedSetting_Load(object sender, EventArgs e)
      {
         cbbMaVB.Properties.Items.Clear();
         cbbMaVB.Properties.Items.AddRange(DataProvider.Instance.getCodes());
         codes = DataProvider.Instance.getCodes();
      }

      private void cbbMaVB_SelectedIndexChanged(object sender, EventArgs e)
      {
         if(cbbMaVB.SelectedIndex < 0)
         {
            return;
         }
         this.id = codes[cbbMaVB.SelectedIndex].Id;
         loadData();
      }
      private void loadData()
      {
         list = DataProvider.Instance.getRelatingCodes(this.id);
         gridControl1.DataSource = list;
      }

      private void btnRefresh_Click(object sender, EventArgs e)
      {
         codes = DataProvider.Instance.getCodes();
         cbbMaVB.Properties.Items.Clear();
         cbbMaVB.Properties.Items.AddRange(codes);
         refreshForm();
      }

      private void btnThem_Click(object sender, EventArgs e)
      {
         if(edtMaLQ.Text.Equals("") || cbbMaVB.Text.Equals(""))
         {
            return;
         } 
         if (DataProvider.Instance.checkRelatingCodeExist(this.id, edtMaLQ.Text.Trim()))
         {
            XtraMessageBox.Show("Mã văn bản liên quan đã tồn tại");
            return;
         }

         bool check = DataProvider.Instance.addRelatingCode(this.id, edtMaLQ.Text);
         if (!check)
         {
            XtraMessageBox.Show("Có lỗi xảy ra");
         }
         else
         {
            edtMaLQ.Text = "";
            XtraMessageBox.Show("Đã thêm");
            loadData();
         }
      }

      private void btnXoa_Click(object sender, EventArgs e)
      {
         if(gridView1.FocusedRowHandle < 0)
         {
            return;
         }
         RelatingCode code = list[gridView1.FocusedRowHandle];
         bool check = DataProvider.Instance.deleteRelatingCode(this.id, code.Name);
         if (!check)
         {
            XtraMessageBox.Show("Có lỗi xảy ra");
         }
         else
         {
            XtraMessageBox.Show("Đã xóa");
            loadData();
         }
      }
      public void refreshForm()
      {
         cbbMaVB.Text = "";
         edtMaLQ.Text = "";
         gridControl1.DataSource = null;
         codes = DataProvider.Instance.getCodes();
         cbbMaVB.Properties.Items.Clear();
         cbbMaVB.Properties.Items.AddRange(codes);
      }
   }
}
