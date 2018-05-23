namespace ScanningDoc
{
   partial class frmTesting
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.btnLoad = new System.Windows.Forms.Button();
         this.txtResult = new System.Windows.Forms.TextBox();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnLoad
         // 
         this.btnLoad.Location = new System.Drawing.Point(108, 12);
         this.btnLoad.Name = "btnLoad";
         this.btnLoad.Size = new System.Drawing.Size(75, 23);
         this.btnLoad.TabIndex = 0;
         this.btnLoad.Text = "LOAD";
         this.btnLoad.UseVisualStyleBackColor = true;
         this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
         // 
         // txtResult
         // 
         this.txtResult.Location = new System.Drawing.Point(13, 69);
         this.txtResult.Multiline = true;
         this.txtResult.Name = "txtResult";
         this.txtResult.Size = new System.Drawing.Size(259, 26);
         this.txtResult.TabIndex = 1;
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "Capture";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 50);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(37, 13);
         this.label1.TabIndex = 2;
         this.label1.Text = "Result";
         // 
         // frmTesting
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(284, 115);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtResult);
         this.Controls.Add(this.btnLoad);
         this.Name = "frmTesting";
         this.Text = "Testing";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnLoad;
      private System.Windows.Forms.TextBox txtResult;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Label label1;
   }
}

