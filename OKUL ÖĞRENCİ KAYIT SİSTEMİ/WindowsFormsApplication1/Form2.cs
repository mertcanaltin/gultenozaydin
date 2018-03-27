using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOX;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\kullanıcı girişli 2\WindowsFormsApplication1\bin\Debug");
            baglanti.Open();
            string sorgu = ("INSERT INTO uye (Ad,Soyad,tc_kımlık_no,sıfre,sıfre_tekrar,e_posta)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')");
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("VERİLER EKLENDİ");
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            
        }
    }
}
