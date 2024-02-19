using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAbasvuruFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbasvur_Click(object sender, EventArgs e)
        {
            int yas = Convert.ToInt32(textBox1.Text);
            bool cSharp = checkBox5.Checked;
            bool askerlik = checkBox4.Checked;
            bool ingilizce = checkBox3.Checked;
            bool Pc1 = checkBox2.Checked;

            if (yas <30 && cSharp == true && askerlik == true && ingilizce == true && Pc1 == true)
            {
                MessageBox.Show("Başvuru Başarılı");
            }

            else
            { MessageBox.Show("Başvuru Başarızıdır.!"); }


        }



    }
}
