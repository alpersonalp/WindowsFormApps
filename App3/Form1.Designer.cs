namespace App3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblsayac = new System.Windows.Forms.Label();
            this.btnsayac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGosterGizle = new System.Windows.Forms.Button();
            this.btnBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblsayac
            // 
            this.lblsayac.AutoSize = true;
            this.lblsayac.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblsayac.Location = new System.Drawing.Point(110, 12);
            this.lblsayac.Name = "lblsayac";
            this.lblsayac.Size = new System.Drawing.Size(74, 89);
            this.lblsayac.TabIndex = 0;
            this.lblsayac.Text = "0";
            // 
            // btnsayac
            // 
            this.btnsayac.Location = new System.Drawing.Point(69, 124);
            this.btnsayac.Name = "btnsayac";
            this.btnsayac.Size = new System.Drawing.Size(154, 87);
            this.btnsayac.TabIndex = 1;
            this.btnsayac.Text = "Arttır";
            this.btnsayac.UseVisualStyleBackColor = true;
            this.btnsayac.Click += new System.EventHandler(this.btnsayac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsayac);
            this.groupBox1.Controls.Add(this.lblsayac);
            this.groupBox1.Location = new System.Drawing.Point(39, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayaç Örnek";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGosterGizle);
            this.groupBox2.Controls.Add(this.btnBut);
            this.groupBox2.Location = new System.Drawing.Point(430, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 217);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnGosterGizle
            // 
            this.btnGosterGizle.Location = new System.Drawing.Point(93, 143);
            this.btnGosterGizle.Name = "btnGosterGizle";
            this.btnGosterGizle.Size = new System.Drawing.Size(141, 49);
            this.btnGosterGizle.TabIndex = 1;
            this.btnGosterGizle.TabStop = false;
            this.btnGosterGizle.Text = "Goster/Gizle";
            this.btnGosterGizle.UseVisualStyleBackColor = true;
            this.btnGosterGizle.Click += new System.EventHandler(this.btnGosterGizle_Click);
            // 
            // btnBut
            // 
            this.btnBut.Location = new System.Drawing.Point(68, 32);
            this.btnBut.Name = "btnBut";
            this.btnBut.Size = new System.Drawing.Size(189, 69);
            this.btnBut.TabIndex = 0;
            this.btnBut.UseVisualStyleBackColor = true;
            this.btnBut.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblsayac;
        private Button btnsayac;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGosterGizle;
        private Button btnBut;
    }
}