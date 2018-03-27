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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\kullanıcı girişli 2\WindowsFormsApplication1\bin\Debug\mert.accdb");
            baglanti.Open();
            string sorgu = "SELECT * FROM uye order by Ad,sıfre";
            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
            OleDbDataReader rdr = komut.ExecuteReader();
            while (rdr.Read())
            {
                string a = (textBox1.Text);
                string b = (textBox2.Text);
                if (a == rdr[0].ToString() && b == rdr[3].ToString())
                {
                    Form3 frm2 = new Form3();
                    frm2.Show();
                }
                else
                    MessageBox.Show("Kullanıcı Adı veya Şifre HATALI !!!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
