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
    public partial class AddForm10 : Form
    {
        public AddForm10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 main = this.Owner as Form3;
            if (main != null)
            {
                DataRow nRow = main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[16].NewRow();
                int rc = main.dataGridView1.RowCount - 13;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[16].Rows.Add(nRow);
                main.тип_оплатыTableAdapter.Update(main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_оплаты);
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[16].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
            }
        }
    }
}
