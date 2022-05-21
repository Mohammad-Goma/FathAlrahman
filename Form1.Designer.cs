
namespace FathAlrahman
{
    partial class Form1
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
            this.txt_Parcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Parcode
            // 
            this.txt_Parcode.Location = new System.Drawing.Point(34, 67);
            this.txt_Parcode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_Parcode.Name = "txt_Parcode";
            this.txt_Parcode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Parcode.Size = new System.Drawing.Size(372, 29);
            this.txt_Parcode.TabIndex = 0;
            this.txt_Parcode.TextChanged += new System.EventHandler(this.txt_Parcode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "الباركود";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "أسم الصنف";
            // 
            // Product_Name
            // 
            this.Product_Name.Location = new System.Drawing.Point(34, 194);
            this.Product_Name.Margin = new System.Windows.Forms.Padding(6);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Product_Name.Size = new System.Drawing.Size(372, 29);
            this.Product_Name.TabIndex = 3;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(34, 259);
            this.Price.Margin = new System.Windows.Forms.Padding(6);
            this.Price.Name = "Price";
            this.Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Price.Size = new System.Drawing.Size(372, 29);
            this.Price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "قيمة الصنف";
            // 
            // QTY
            // 
            this.QTY.Location = new System.Drawing.Point(34, 324);
            this.QTY.Margin = new System.Windows.Forms.Padding(6);
            this.QTY.Name = "QTY";
            this.QTY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QTY.Size = new System.Drawing.Size(372, 29);
            this.QTY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "الكمية المتوفرة";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 397);
            this.Controls.Add(this.QTY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Parcode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Parcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QTY;
        private System.Windows.Forms.Label label4;
    }
}

