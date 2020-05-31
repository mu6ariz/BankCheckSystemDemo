namespace Banksystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_cek = new System.Windows.Forms.Label();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_em = new System.Windows.Forms.Button();
            this.btn_k = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_service = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Controls.Add(this.lbl_cek);
            this.groupBox1.Controls.Add(this.btn_c);
            this.groupBox1.Controls.Add(this.btn_em);
            this.groupBox1.Controls.Add(this.btn_k);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(55, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal";
            // 
            // lbl_cek
            // 
            this.lbl_cek.AutoSize = true;
            this.lbl_cek.Location = new System.Drawing.Point(71, 262);
            this.lbl_cek.Name = "lbl_cek";
            this.lbl_cek.Size = new System.Drawing.Size(0, 20);
            this.lbl_cek.TabIndex = 3;
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(71, 189);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(114, 54);
            this.btn_c.TabIndex = 2;
            this.btn_c.Text = "Cassa";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // btn_em
            // 
            this.btn_em.Location = new System.Drawing.Point(71, 122);
            this.btn_em.Name = "btn_em";
            this.btn_em.Size = new System.Drawing.Size(114, 50);
            this.btn_em.TabIndex = 1;
            this.btn_em.Text = "Emeliyyatlar";
            this.btn_em.UseVisualStyleBackColor = true;
            this.btn_em.Click += new System.EventHandler(this.btn_em_Click);
            // 
            // btn_k
            // 
            this.btn_k.Location = new System.Drawing.Point(71, 52);
            this.btn_k.Name = "btn_k";
            this.btn_k.Size = new System.Drawing.Size(114, 52);
            this.btn_k.TabIndex = 0;
            this.btn_k.Text = "Komunal";
            this.btn_k.UseVisualStyleBackColor = true;
            this.btn_k.Click += new System.EventHandler(this.btn_k_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Controls.Add(this.lbl_service);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(608, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Musteri Xidmetleri";
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Location = new System.Drawing.Point(57, 221);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(0, 20);
            this.lbl_service.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "XIDMET ET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(966, 610);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_cek;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_em;
        private System.Windows.Forms.Button btn_k;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_service;
    }
}

