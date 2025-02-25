namespace YSSAutoFolderCreater
{
    partial class Ana_Sayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Sayfa));
            this.label_fatura = new System.Windows.Forms.Label();
            this.label_plaka = new System.Windows.Forms.Label();
            this.label_tarih = new System.Windows.Forms.Label();
            this.textBox_Fatura = new System.Windows.Forms.TextBox();
            this.textBox_plaka = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_cikis = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_fatura
            // 
            resources.ApplyResources(this.label_fatura, "label_fatura");
            this.label_fatura.Name = "label_fatura";
            // 
            // label_plaka
            // 
            resources.ApplyResources(this.label_plaka, "label_plaka");
            this.label_plaka.Name = "label_plaka";
            // 
            // label_tarih
            // 
            resources.ApplyResources(this.label_tarih, "label_tarih");
            this.label_tarih.Name = "label_tarih";
            // 
            // textBox_Fatura
            // 
            this.textBox_Fatura.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("textBox_Fatura.AutoCompleteCustomSource")});
            this.textBox_Fatura.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            resources.ApplyResources(this.textBox_Fatura, "textBox_Fatura");
            this.textBox_Fatura.Name = "textBox_Fatura";
            this.textBox_Fatura.UseWaitCursor = true;
            // 
            // textBox_plaka
            // 
            resources.ApplyResources(this.textBox_plaka, "textBox_plaka");
            this.textBox_plaka.Name = "textBox_plaka";
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Name = "dateTimePicker1";
            // 
            // button_cikis
            // 
            this.button_cikis.DialogResult = System.Windows.Forms.DialogResult.Abort;
            resources.ApplyResources(this.button_cikis, "button_cikis");
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // button_kaydet
            // 
            resources.ApplyResources(this.button_kaydet, "button_kaydet");
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            this.button_kaydet.Click += new System.EventHandler(this.button_kaydet_Click);
            // 
            // Ana_Sayfa
            // 
            this.AcceptButton = this.button_kaydet;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_cikis;
            this.Controls.Add(this.button_kaydet);
            this.Controls.Add(this.button_cikis);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_plaka);
            this.Controls.Add(this.textBox_Fatura);
            this.Controls.Add(this.label_tarih);
            this.Controls.Add(this.label_plaka);
            this.Controls.Add(this.label_fatura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ana_Sayfa";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_fatura;
        private System.Windows.Forms.Label label_plaka;
        private System.Windows.Forms.Label label_tarih;
        private System.Windows.Forms.TextBox textBox_Fatura;
        private System.Windows.Forms.TextBox textBox_plaka;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

