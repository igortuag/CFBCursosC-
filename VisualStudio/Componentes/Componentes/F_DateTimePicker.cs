using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_ObterData_Click(object sender, EventArgs e)
        {
            tb_Data.Text = dtp_Data.Text;
            tb_Dia.Text = dtp_Data.Value.Day.ToString();
            tb_Mes.Text = dtp_Data.Value.Month.ToString();
            tb_Ano.Text = dtp_Data.Value.Year.ToString();
        }

        private void btn_SetarData_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(tb_Dia.Text);
            m = Int32.Parse(tb_Mes.Text);
            a = Int32.Parse(tb_Ano.Text);

            DateTime dt = new DateTime(a,m,d);

            dtp_Data.Value = dt;
            tb_Data.Text = dtp_Data.Text;
        }

        private void btn_Hoje_Click(object sender, EventArgs e)
        {
            dtp_Data.Value = DateTime.Today;
        }
    }
}
