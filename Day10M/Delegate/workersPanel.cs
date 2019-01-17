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
    public partial class workersPanel : Form
    {
        public workersPanel()
        {
            InitializeComponent();
        }

        private void btn_comfirm_Click(object sender, EventArgs e)
        {
            var Name = txt_name.Text;
            var Surname = txt_surname.Text;
            var Email =txt_email.Text;
            var Maas = Convert.ToInt32(txt_maas.Text);
            var Saat = Convert.ToInt32(txt_isSaati.Text);
            var WorkDate = Convert.ToDateTime(dtp_workDate.Text);

            var worker = new Workers(Name, Surname, Email, Maas, Saat,WorkDate);

            Db.MyWorkers.Add(worker);

            dgv_addWorker.DataSource =Db.MyWorkers;

            UpdateData();
            

        }

        public void UpdateData()
        {
            dgv_addWorker.Update();
            dgv_addWorker.Refresh();

            var bind = new BindingSource();
            bind.DataSource= Db.MyWorkers;
            dgv_addWorker.DataSource = bind;

        }
    }
}
