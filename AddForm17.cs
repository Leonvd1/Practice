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
    public partial class AddForm17 : Form
    {
        public AddForm17()
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
                DataRow nRow = main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[8].NewRow();
                int rc = main.dataGridView1.RowCount - 13;
                nRow[0] = rc;
                nRow[1] = tbPost.Text;
                nRow[2] = tbNumb.Text;
                nRow[3] = tbFam.Text;
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[8].Rows.Add(nRow);
                main.поставщикTableAdapter.Update(main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Поставщик);
                main._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Tables[8].AcceptChanges();
                main.dataGridView1.Refresh();
                tbPost.Text = "";
                tbNumb.Text = "";
                tbFam.Text = "";
            }
        }
    }
}
