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
using ScanningDoc.DTO;

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
         btnProccess.Enabled = false;
         ((frmMain)this.MdiParent).setBtnEnable(false);
         CoreProcesser core = new CoreProcesser();
         Thread newThread = new Thread(
                delegate ()
                {

                   //DirectoryInfo sourceInfo = new DirectoryInfo(edtFolder.Text);
                   //FileInfo[] files = sourceInfo.GetFiles();

                   List<Tuple<string, string>> list = getPathAndFileName(edtFolder.Text);

                   if(list.Count() == 0)
                   {
                      XtraMessageBox.Show("Hoàn tất");
                      Invoke((MethodInvoker)delegate
                      {
                         btnProccess.Enabled = true;
                         ((frmMain)this.MdiParent).setBtnEnable(true);
                      });
                      return;
                   }

                   int fileQuantity = list.Count(), processedFileQuantity = 0;
                   int step = 100 / fileQuantity;
                   Invoke((MethodInvoker)delegate
                   {
                      edtKQ.Text = "";
                      lbFile.Text = fileQuantity.ToString();
                      lbProcessedFile.Text = processedFileQuantity.ToString();
                      progressBarControl1.EditValue = 0;
                   });





                   //foreach (FileInfo file in files)
                   //{
                   //   string code = core.getCode(file.FullName);

                   //   string filePathInp = file.FullName;
                   //   string fileName = file.Name;
                   //   bool check = moveFile(filePathInp, fileName, code);
                   //   Invoke((MethodInvoker)delegate
                   //   {
                   //      edtKQ.Text += code + "  ";
                   //      if (check)
                   //      {
                   //         processedFileQuantity++;
                   //         lbProcessedFile.Text = processedFileQuantity.ToString();
                   //         progressBarControl1.Position += step;
                   //      }
                   //   });
                   //}

                   foreach (Tuple<string, string> tp in list)
                   {
                      string code = core.getCode(tp.Item1);

                      string filePathInp = tp.Item1;
                      string fileName = tp.Item2;
                      bool check = moveFile(filePathInp, fileName, code);
                      Invoke((MethodInvoker)delegate
                      {
                         edtKQ.Text += code + "  ";
                         if (check)
                         {
                            processedFileQuantity++;
                            lbProcessedFile.Text = processedFileQuantity.ToString();
                            progressBarControl1.Position += step;
                         }
                      });
                   }

                   XtraMessageBox.Show("Hoàn tất");
                   Invoke((MethodInvoker)delegate
                   {
                      btnProccess.Enabled = true;
                      ((frmMain)this.MdiParent).setBtnEnable(true);
                   });
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
         refreshData();
      }
      public void refreshData()
      {
         links = DataProvider.Instance.getLinks();
         pdfFolderPath = DataProvider.Instance.getPDFFolderPath();
      }

      private bool moveFile(string filePathInp, string fileName, string code)
      {
         List<Link> links = DataProvider.Instance.getLinks();
         if (links == null)
         {
            return false;
         }
         Code _code = DataProvider.Instance.getCode(code);
         Path _path = null;
         bool flag = false;
         if (_code != null && DataProvider.Instance.checkCodeExistInLinks(_code.Id))
         {
            flag = true;
            _path = DataProvider.Instance.getPathFromCodeInLink(_code.Id);
         }
         else
         {
            ///bugggggggggggggggggggggggggggg
            foreach (Link link in links)
            {
               if (DataProvider.Instance.checkRelatingCodeExist(link.Code.Id, code))
               {
                  flag = true;
                  _path = link.Path;
               }
            }
         }
         if (flag)
         {
            if (!Directory.Exists(_path.Name))
            {
               Directory.CreateDirectory(_path.Name);
            }
            //FileInfo file = new FileInfo(filePathInp);
            //file.CopyTo(System.IO.Path.Combine(_path.Name, file.Name));
            //file.Delete();
            //file.MoveTo(_path.Name + @"\" + file.Name);
            //File.Move(filePathInp, _path.Name + @"\" + fileName);
            move(filePathInp, _path.Name);
         }
         return flag;
      }

      private List<Tuple<string, string>> getPathAndFileName(string folderPath)
      {
         DirectoryInfo sourceInfo = new DirectoryInfo(folderPath);
         FileInfo[] files = sourceInfo.GetFiles();
         List<Tuple<string, string>> list = new List<Tuple<string, string>>();
         foreach (FileInfo file in files)
         {
            if (file.Extension != ".pdf")
            {
               continue;
            }
            string filePathInp = file.FullName;
            string fileName = file.Name;
            Tuple<string, string> tp = Tuple.Create(filePathInp, fileName);
            list.Add(tp);
         }
         return list;
      }
      private void move(string filePathNameToMove, string directoryPathToMove)
      {
         if (File.Exists(filePathNameToMove))
         {
            string destinationFilePathName =
                   System.IO.Path.Combine(directoryPathToMove, System.IO.Path.GetFileName(filePathNameToMove));
            if (!File.Exists(destinationFilePathName))
            {
               try
               {
                  File.Move(filePathNameToMove, destinationFilePathName);
                  Console.WriteLine("File Moved!");
               }
               catch (Exception e)
               {
                  Console.WriteLine("File Not Moved! Error:" + e.Message);

               }
            }
         }
      }
   }
}
