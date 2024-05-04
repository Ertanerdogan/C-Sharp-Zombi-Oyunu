namespace Zombi_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.canLabel = new System.Windows.Forms.Label();
            this.LblMermi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.karakter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAN :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1230, 7);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(210, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // canLabel
            // 
            this.canLabel.AutoSize = true;
            this.canLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.canLabel.Location = new System.Drawing.Point(1301, 33);
            this.canLabel.Name = "canLabel";
            this.canLabel.Size = new System.Drawing.Size(78, 19);
            this.canLabel.TabIndex = 2;
            this.canLabel.Text = "100 / 100";
            // 
            // LblMermi
            // 
            this.LblMermi.AutoSize = true;
            this.LblMermi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMermi.Location = new System.Drawing.Point(12, 9);
            this.LblMermi.Name = "LblMermi";
            this.LblMermi.Size = new System.Drawing.Size(73, 19);
            this.LblMermi.TabIndex = 3;
            this.LblMermi.Text = "MERMİ :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(580, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "SKOR : 0";
            // 
            // karakter
            // 
            this.karakter.Image = global::Zombi_Oyunu.Properties.Resources.adam_sol;
            this.karakter.Location = new System.Drawing.Point(551, 251);
            this.karakter.Name = "karakter";
            this.karakter.Size = new System.Drawing.Size(120, 90);
            this.karakter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.karakter.TabIndex = 4;
            this.karakter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1216, 679);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.karakter);
            this.Controls.Add(this.LblMermi);
            this.Controls.Add(this.canLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zombi Avcısı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.karakter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label canLabel;
        private System.Windows.Forms.Label LblMermi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox karakter;
        private System.Windows.Forms.Label label3;
    }
}

