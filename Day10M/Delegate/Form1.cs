using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        private object worker;
        public void UpdateDataOrtalama()
        {
            dgv_w.Update();
            dgv_w.Refresh();

            var ortaBind = new BindingSource();
            ortaBind.DataSource = Db.OtradanYuxari;
            dgv_w.DataSource = ortaBind;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addPanel = new workersPanel();
            addPanel.Show();
            

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv_w.DataSource = Db.MyWorkers;
           
        }

        private void btn_ortalama_Click(object sender, EventArgs e)
        {
           
            var maaslar = 0;
            var ortalama = 0;
            var iscilerinSayi = 0;
            foreach (var item in Db.MyWorkers)
            {
                maaslar += item.Maas;
                iscilerinSayi = item.WorkerId;
                
            }
            ortalama = maaslar / iscilerinSayi;
            lbl_orta.Text = ortalama.ToString() + " AZN";
           
        }

        private void btn_maasOrtaYuxari_Click(object sender, EventArgs e)
        {
            UpdateDataOrtalama();
            Db.OtradanYuxari.Clear();
           

            cmbx_worker.Items.Clear();
            var maaslar = 0;
            var ortalama = 0;
            var iscilerinSayi = 0;
            foreach (var item in Db.MyWorkers)
            {
                maaslar += item.Maas;
                iscilerinSayi = item.WorkerId;

            }
            ortalama = maaslar / iscilerinSayi;
            foreach (var item in Db.MyWorkers)
            {
                if (item.Maas > ortalama)
                {
                    
                     
                    var Worker = item.Name + " " + item.Surname;
                    cmbx_worker.Items.Add(Worker.ToString());

                    Db.OtradanYuxari.Add(item);
                   
                    
                }
            }

           


        }


        private void button2_Click(object sender, EventArgs e)
        {
            var rowCount = dgv_w.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                if (dgv_w.Rows[i].IsNewRow == false)
                {
                    dgv_w.Rows.RemoveAt(i);
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
