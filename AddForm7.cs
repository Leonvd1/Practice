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
    public partial class AddForm7 : Form
    {
        public AddForm7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            if (main != null)
            {
                DataRow nRow = main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount - 12;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[0].Rows.Add(nRow);
                main.должностьTableAdapter.Update(main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Должность);
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
            }
        }
    }
}
