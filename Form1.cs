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
    public partial class OrgZan : Form
    {
        public OrgZan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Направление_занятия". При необходимости она может быть перемещена или удалена.
            this.направление_занятияTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Направление_занятия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Организация_занятий". При необходимости она может быть перемещена или удалена.
            this.организация_занятийTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Организация_занятий);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Квалификация". При необходимости она может быть перемещена или удалена.
            this.квалификацияTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Квалификация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Категория_абонемента". При необходимости она может быть перемещена или удалена.
            this.категория_абонементаTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Категория_абонемента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Срок_действия". При необходимости она может быть перемещена или удалена.
            this.срок_действияTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Срок_действия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_оплаты". При необходимости она может быть перемещена или удалена.
            this.статус_оплатыTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_оплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_сортировки". При необходимости она может быть перемещена или удалена.
            this.статус_сортировкиTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_сортировки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_доставки". При необходимости она может быть перемещена или удалена.
            this.тип_доставкиTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_доставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_занятия". При необходимости она может быть перемещена или удалена.
            this.тип_занятияTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_занятия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_оплаты". При необходимости она может быть перемещена или удалена.
            this.тип_оплатыTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_оплаты);

        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GoToForm2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void GoToSotAndKli_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddForm3 af = new AddForm3();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm1 sf = new SearchForm1();
            sf.Owner = this;
            sf.Show();
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddForm1 af = new AddForm1();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddForm2 af = new AddForm2();
            af.Owner = this;
            af.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SaveBtn1_Click(object sender, EventArgs e)
        {
            направлениеЗанятияBindingSource.EndEdit();
            направление_занятияTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            RunForm frm4 = new RunForm();
            frm4.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            организацияЗанятийBindingSource.EndEdit();
            организация_занятийTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            типЗанятияBindingSource.EndEdit();
            тип_занятияTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }
    }
}
