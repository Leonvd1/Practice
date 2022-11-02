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
    public partial class AddForm14 : Form
    {
        public AddForm14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            if (main != null)
            {
                DataRow nRow = main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[7].NewRow();
                int rc = main.dataGridView1.RowCount +0;
                nRow[0] = rc;
                nRow[1] = tbDate.Text;
                nRow[2] = tbNumb.Text;
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[7].Rows.Add(nRow);
                main.поставка_товараTableAdapter.Update(main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Поставка_товара);
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[7].AcceptChanges();
                main.dataGridView1.Refresh();
                tbDate.Text = "";
                tbNumb.Text = "";
            }
        }
    }
}
