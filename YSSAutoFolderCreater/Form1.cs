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

namespace YSSAutoFolderCreater
{
    public partial class Ana_Sayfa : Form
    {   
        public Ana_Sayfa()
        {
            InitializeComponent();
        }
            private void button_kaydet_Click(object sender, EventArgs e)
        {
            
            //kullanıcı bilgisi alma
            string faturaNumarasi = textBox_Fatura.Text;
            string aracPlakasi = textBox_plaka.Text;
            string yuklemeTarihi = dateTimePicker1.Value.ToString("dd-MM-yyyy");

            //klasör adı oluştur, Kendi test sunucuma dosyaları oluşturdum. şayet bilgisayarınızdaki masaüstüne oluşturmak için aşağıdaki kod ile değişim yapmalısınız.
            //string klasorYolu = Path.Combine(Environment.SpecialFolder.Desktop, klasorAdi); (doğruluğunu denemedim sadece teorik bilgi)
            string klasorAdi = $"{faturaNumarasi} - {aracPlakasi} - {yuklemeTarihi}";
            string klasorYolu = Path.Combine(@"\\192.168.1.5\yukleme kayitlari", klasorAdi);


            // Oluşturduğumuz klasörün içine yeni bir klasör oluşturmak için yazdıma ancak bu alan eksik kalmış olup bir boş vaktimde uğraşacağım için comment olarak yazdım
           // string klasoriki = "YÜKLEME GÖRSEL ve VİDEOLARI";
            //string klasorikiyol = Path.Combine(@"\\192.168.1.5\yukleme kayitlari\$klasorAdi\");
            try
            {
                // Klasörü oluştur
                Directory.CreateDirectory(klasorYolu);
                MessageBox.Show("Klasör başarıyla oluşturuldu: " + klasorYolu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klasör oluşturulurken bir hata oluştu: " + ex.Message);
            }
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
