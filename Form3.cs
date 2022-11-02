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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Категория_абонемента". При необходимости она может быть перемещена или удалена.
            this.категория_абонементаTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Категория_абонемента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Срок_действия". При необходимости она может быть перемещена или удалена.
            this.срок_действияTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Срок_действия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_оплаты". При необходимости она может быть перемещена или удалена.
            this.статус_оплатыTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_оплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_оплаты". При необходимости она может быть перемещена или удалена.
            this.тип_оплатыTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_оплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Приобретение_абонемента". При необходимости она может быть перемещена или удалена.
            this.приобретение_абонементаTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Приобретение_абонемента);

        }

        private void GoToForm1_Click(object sender, EventArgs e)
        {
            OrgZan frm1 = new OrgZan();
            frm1.Show();
            this.Hide();
        }

        private void GoToForm4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm4 sf = new SearchForm4();
            sf.Owner = this;
            sf.Show();
        }

        private void GoToSotAndKli_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm9 af = new AddForm9();
            af.Owner = this;
            af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddForm10 af = new AddForm10();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddForm11 af = new AddForm11();
            af.Owner = this;
            af.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddForm12 af = new AddForm12();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddForm13 af = new AddForm13();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            типОплатыBindingSource.EndEdit();
            тип_оплатыTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            приобретениеАбонементаBindingSource.EndEdit();
            приобретение_абонементаTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            срокДействияBindingSource.EndEdit();
            срок_действияTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            статусОплатыBindingSource.EndEdit();
            статус_оплатыTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            категорияАбонементаBindingSource.EndEdit();
            категория_абонементаTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
