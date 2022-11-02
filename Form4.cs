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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_оплаты". При необходимости она может быть перемещена или удалена.
            this.тип_оплатыTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_оплаты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_сортировки". При необходимости она может быть перемещена или удалена.
            this.статус_сортировкиTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Статус_сортировки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_доставки". При необходимости она может быть перемещена или удалена.
            this.тип_доставкиTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Тип_доставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Поставщик". При необходимости она может быть перемещена или удалена.
            this.поставщикTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Поставщик);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Поставка_товара". При необходимости она может быть перемещена или удалена.
            this.поставка_товараTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Поставка_товара);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForm5 sf = new SearchForm5();
            sf.Owner = this;
            sf.Show();
        }

        private void PrevToForm1_Click(object sender, EventArgs e)
        {
            OrgZan frm1 = new OrgZan();
            frm1.Show();
            this.Hide();
        }

        private void GoToForm3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void GoToForm4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm14 af = new AddForm14();
            af.Owner = this;
            af.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddForm15 af = new AddForm15();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddForm17 af = new AddForm17();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddForm16 af = new AddForm16();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            статусСортировкиBindingSource.EndEdit();
            статус_сортировкиTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            поставкаТовараBindingSource.EndEdit();
            поставка_товараTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            типДоставкиBindingSource.EndEdit();
            тип_доставкиTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            поставщикBindingSource.EndEdit();
            поставщикTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
