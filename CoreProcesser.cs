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
   public class CoreProcesser
   {
      public CoreProcesser()
      {

      }
      public string getCode(string filePDFFullName)
      {
         string type;
         string fileNameLocation = convertPDFtoJPG(filePDFFullName);
         using (Image img = Image.FromFile(fileNameLocation))
         {
            string result = tesseractORC(cropImage(img));
            type = processString(result);
         }
         FileInfo file = new FileInfo(fileNameLocation);
         file.Delete();
         return type;
      }

      private String tesseractORC(Image img)
      {
         var item = new Bitmap(img);
         var ocr = new TesseractEngine("./tessdata", "vie", EngineMode.Default);
         var page = ocr.Process(item);
         return page.GetText();
      }
      private String convertPDFtoJPG(string filePDFFullName)
      {
         int len = filePDFFullName.LastIndexOf(".");
         string fileLocation = filePDFFullName.Substring(0, len) + ".jpg";
         SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
         f.OpenPdf(@filePDFFullName);
         if (f.PageCount > 0)
         {
            f.ImageOptions.Dpi = 300;
            f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
            f.ToImage(fileLocation, 1);
         }
         f.ClosePdf();
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
   }


}
