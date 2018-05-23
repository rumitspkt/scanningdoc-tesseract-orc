using DevExpress.XtraEditors;
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
      List<Link> links;
      List<Code> codes;
      List<Path> paths;
      public frmSetting()
      {
         InitializeComponent();
         //listLink = new List<Link>();
         //listLink.Add(new Link("CV", "E:\\DuLieu\\TaiLieu\\CongVan"));
         //listLink.Add(new Link("DA", "E:\\DuLieu\\TaiLieu\\DuAn"));
         //gcLink.DataSource = listLink;
      }

      private void frmSetting_Load(object sender, EventArgs e)
      {
         loadData();
         gcLink.DataSource = links;
      }
      private void loadData()
      {
         codes = DataProvider.Instance.getCodes();
         paths = DataProvider.Instance.getPaths();
         links = DataProvider.Instance.getLinks();
         cbbMaVB.Properties.Items.Clear();
         cbbMaVB.Properties.Items.AddRange(codes);
         cbbDuongDan.Properties.Items.Clear();
         cbbDuongDan.Properties.Items.AddRange(paths);
         gcLink.DataSource = links;
         cbbDuongDan.Text = "";
         cbbMaVB.Text = "";
      }

      private void btnThemMaVB_Click(object sender, EventArgs e)
      {
         if (DataProvider.Instance.checkCodeExist(tdMaVB.Text.Trim()))
         {
            XtraMessageBox.Show("Mã văn bản đã tồn tại");
            return;
         }
         int id;
         if(codes.Count == 0)
         {
            id = 1;
         }
         else
         {
            id = codes.Last().Id + 1;
         }

         bool check = DataProvider.Instance.addCode(id, tdMaVB.Text.Trim());
         if (!check)
         {
            XtraMessageBox.Show("Có lỗi xảy ra");
         }
         else
         {
            tdMaVB.Text = "";
            XtraMessageBox.Show("Đã thêm");
            if(frmMain.advancedSetting != null)
               frmMain.advancedSetting.refreshForm();
            loadData();
         }
      }

      private void btnTimDuongDan_Click(object sender, EventArgs e)
      {
         folderBrowserDialog1.ShowDialog();
         tdDuongDan.Text = folderBrowserDialog1.SelectedPath;
      }

      private void btnThemDuongDan_Click(object sender, EventArgs e)
      {
         if(tdDuongDan.Text == "")
         {
            return;
         }
         if (DataProvider.Instance.checkPathExist(@tdDuongDan.Text))
         {
            XtraMessageBox.Show("Đường dẫn đã tồn tại");
            return;
         }
         int id;
         if (paths.Count == 0)
         {
            id = 1;
         }
         else
         {
            id = paths.Last().Id + 1;
         }
         if(tdDuongDan.Text.Last() == '\\')
         {
            tdDuongDan.Text = tdDuongDan.Text.Remove(tdDuongDan.Text.Length - 1);
         }

         bool check = DataProvider.Instance.addPath(id, @tdDuongDan.Text);
         if (!check)
         {
            XtraMessageBox.Show("Có lỗi xảy ra");
         }
         else
         {
            tdDuongDan.Text = "";
            XtraMessageBox.Show("Đã thêm");
            loadData();
         }
      }

      private void btnThemLK_Click(object sender, EventArgs e)
      {
         if(cbbDuongDan.Text.Equals("") || cbbMaVB.Text.Equals(""))
         {
            return;               
         }
         Code code = codes[cbbMaVB.SelectedIndex];
         Path path = paths[cbbDuongDan.SelectedIndex];
          
         if (DataProvider.Instance.checkLinkExist(code.Id, path.Id))
         {
            XtraMessageBox.Show("Liên kết đã tồn tại");
            cbbDuongDan.Text = "";
            cbbMaVB.Text = "";
            return;
         }
         bool check = DataProvider.Instance.addLink(code.Id, path.Id);
         if (!check)
         {
            XtraMessageBox.Show("Có lỗi xảy ra");
         }
         else
         {
            tdDuongDan.Text = "";
            XtraMessageBox.Show("Đã thêm");
            frmMain.processing.refreshData();
            loadData();
            cbbDuongDan.Text = "";
            cbbMaVB.Text = "";
         }
      }

      private void btnXoaLK_Click(object sender, EventArgs e)
      {
         if (gvLink.FocusedRowHandle < 0)
         {
            return;
         }
         Link link = links[gvLink.FocusedRowHandle];
         bool check = DataProvider.Instance.deleteLink(link.Code.Id, link.Path.Id);
         if (!check)
         {
            XtraMessageBox.Show("Có lỗi xảy ra");
            cbbDuongDan.Text = "";
            cbbMaVB.Text = "";
         }
         else
         {
            XtraMessageBox.Show("Đã xóa");
            frmMain.processing.refreshData();
            if (frmMain.advancedSetting != null)
               frmMain.advancedSetting.refreshForm();
            loadData();
         }
      }
   }
}
