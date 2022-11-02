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
    public partial class SearchForm1 : Form
    {
        public SearchForm1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            OrgZan main = this.Owner as OrgZan;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView9.RowCount; i++)
                {
                    main.dataGridView9.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView9.ColumnCount; j++)
                        if (main.dataGridView9.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView9.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView9.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }
    }
}
