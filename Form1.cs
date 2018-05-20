using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ScanningDoc
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnORC_Click(object sender, EventArgs e)
      {
         if (openFileDialog1.ShowDialog() == DialogResult.OK)
         {
            string fileNameLocation = convertPDFtoJPG(openFileDialog1.FileName);
            MessageBox.Show(fileNameLocation);
            string result = tesseractORC(cropImage(Image.FromFile(fileNameLocation)));
            textBox1.Text = result;
            string type = processString(result);


            MessageBox.Show(type);
         }
      }
      private String tesseractORC(Image img)
      {
         var item = new Bitmap(img);
         var ocr = new TesseractEngine("./tessdata", "vie", EngineMode.Default);
         var page = ocr.Process(item);
         return page.GetText();
      }
      private String convertPDFtoJPG(string fileNameInp)
      {
         string fileLocation = "";
         string fileNameOut = @"E:\tesseractORC\";
         SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
         f.OpenPdf(@fileNameInp);
         if (f.PageCount > 0)
         {
            f.ImageOptions.Dpi = 300;
            f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;

            int len = openFileDialog1.SafeFileName.LastIndexOf(".");
            string fileName = openFileDialog1.SafeFileName.Substring(0, len);
            fileLocation = @fileNameOut + fileName + ".jpg";
            f.ToImage(fileLocation, 1);
         }
         return fileLocation;
      }

      private Image cropImage(Image img)
      {
         Bitmap bmp = new Bitmap(img);
         int width = img.Width / 2;
         int height = img.Height / 9;
         Rectangle cropArea = new Rectangle(130, 130, width, height);
         return bmp.Clone(cropArea, bmp.PixelFormat);
      }

      private string processString(string str)
      {
         int len = str.Length;
         int posDash = str.IndexOf('-');
         int posSlash = str.IndexOf('/');
         if (posSlash != -1 && posDash != -1 && posDash < posSlash)
         {
            //MessageBox.Show(str.Substring(posDash + 1, posSlash - posDash - 1));
            return str.Substring(posDash + 1, posSlash - posDash - 1);
         }
         if (posDash != -1 && posDash < posSlash)
         {
            return str.Substring(posDash + 1, 2);
         }
         else
         {
            if (posSlash != -1)
            {
               return str.Substring(posSlash - 2, 2);
            }
         }
         return "";
      }

      private void button1_Click(object sender, EventArgs e)
      {
         folderBrowserDialog1.ShowDialog();
      }

      private void button2_Click(object sender, EventArgs e)
      {
         folderBrowserDialog2.ShowDialog();

      }

      private void button3_Click(object sender, EventArgs e)
      {
         DirectoryInfo sourceinfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
         DirectoryInfo target = new DirectoryInfo(folderBrowserDialog2.SelectedPath);
         if (!Directory.Exists(target.FullName))
         {
            Directory.CreateDirectory(target.FullName);
         }
         FileInfo file = new FileInfo(@"C:\Users\RumIT\Desktop\folder2\file1.txt");
         file.Delete();

         foreach (FileInfo fi in sourceinfo.GetFiles())
         {
            if (fi.Length != 0)
               fi.MoveTo(System.IO.Path.Combine(target.ToString(), fi.Name));
         }
      }
   }
}
