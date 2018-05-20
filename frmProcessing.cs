using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ScanningDoc
{
   public partial class frmProcessing : Form
   {
      List<Link> links;
      string pdfFolderPath;
      public frmProcessing()
      {
         InitializeComponent();
      }

      private void simpleButton2_Click(object sender, EventArgs e)
      {
         //proccessing
         CoreProcesser core = new CoreProcesser();
         Thread newThread = new Thread(
                delegate ()
                {
                   
                   DirectoryInfo sourceInfo = new DirectoryInfo(edtFolder.Text);
                   FileInfo[] files = sourceInfo.GetFiles();
                   int fileQuantity = files.Count(), processedFileQuantity = 0;
                   int step = 100 / fileQuantity;
                   Invoke((MethodInvoker)delegate
                   {
                      lbFile.Text = fileQuantity.ToString();
                      progressBarControl1.EditValue = 0;
                   });
                   foreach (FileInfo file in files)
                   {
                      string code = core.getCode(file.FullName);
                      Invoke((MethodInvoker)delegate
                      {
                         edtKQ.Text += code + "  ";
                         bool check = moveFile(file, code);
                         if (check)
                         {
                            processedFileQuantity++;
                            lbProcessedFile.Text = processedFileQuantity.ToString();
                            progressBarControl1.Position += step;
                         }
                      });
                   }
                   XtraMessageBox.Show("Hoàn tất");

                }
            );
         newThread.Start();
      }
      private void btnFindFolder_Click_1(object sender, EventArgs e)
      {
         folderBrowserDialog1.ShowDialog();
         edtFolder.Text = folderBrowserDialog1.SelectedPath;
         DataProvider.Instance.addPDFFolderPath(edtFolder.Text);
      }

      private void frmProcessing_Load(object sender, EventArgs e)
      {
         edtFolder.Text = DataProvider.Instance.getPDFFolderPath();
      }
      public void refreshData()
      {
         links = DataProvider.Instance.getLinks();
         pdfFolderPath = DataProvider.Instance.getPDFFolderPath();
      }
      private void process(string hi) {
         Thread.Sleep(5000);
         MessageBox.Show(hi);
      }
      private bool moveFile(FileInfo file, string code)
      {
         foreach(Link link in links)
         {
            if (link.Code.Name.Equals(code))
            {
               if(!Directory.Exists(link.Path.Name))
               {
                  Directory.CreateDirectory(link.Path.Name);
               }
               file.MoveTo(System.IO.Path.Combine(link.Path.Name, file.Name));
               return true;
            }
         }
         return false;
      }
   }
}
