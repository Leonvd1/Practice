using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Информационная_система_Фитнес_клуба_Fitness_house
{
    public partial class AddForm3 : Form
    {
        public AddForm3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrgZan main = this.Owner as OrgZan;
            if (main != null)
            {
                DataRow nRow = main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 11;
                nRow[0] = rc;
                nRow[1] = tbDate.Text;
                nRow[2] = tbPlan.Text;
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[5].Rows.Add(nRow);
                main.организация_занятийTableAdapter.Update(main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Организация_занятий);
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                tbDate.Text = "";
                tbPlan.Text = "";
            }
        }
    }
}
