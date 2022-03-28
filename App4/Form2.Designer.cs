namespace App4
{
    partial class Form2
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCikart = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(47, 43);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 23);
            this.txtFirst.TabIndex = 0;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(47, 93);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 23);
            this.txtSecond.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(60, 144);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(75, 23);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(60, 180);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(75, 23);
            this.btnCikart.TabIndex = 3;
            this.btnCikart.Text = "Çıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            this.btnCikart.Click += new System.EventHandler(this.btnCikart_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Çarp";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(60, 254);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(75, 23);
            this.btnBol.TabIndex = 5;
            this.btnBol.Text = "Böl";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSonuc.Location = new System.Drawing.Point(64, 307);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(67, 81);
            this.lblSonuc.TabIndex = 6;
            this.lblSonuc.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCikart);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirst;
        private TextBox txtSecond;
        private Button btnTopla;
        private Button btnCikart;
        private Button button3;
        private Button btnBol;
        private Label lblSonuc;
    }
}