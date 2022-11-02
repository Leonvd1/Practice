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
    public partial class AddForm6 : Form
    {
        public AddForm6()
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
                DataRow nRow = main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[2].NewRow();
                int rc = main.dataGridView1.RowCount - 11;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[2].Rows.Add(nRow);
                main.квалификацияTableAdapter.Update(main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Квалификация);
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[2].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
            }
        }
    }
}
