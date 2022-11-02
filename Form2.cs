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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Пол". При необходимости она может быть перемещена или удалена.
            this.полTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Пол);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Квалификация". При необходимости она может быть перемещена или удалена.
            this.квалификацияTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Квалификация);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this._Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet.Сотрудник);

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

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void GoToForm4_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForm2 sf = new SearchForm2();
            sf.Owner = this;
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm3 sf = new SearchForm3();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddForm4 af = new AddForm4();
            af.Owner = this;
            af.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddForm5 af = new AddForm5();
            af.Owner = this;
            af.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddForm6 af = new AddForm6();
            af.Owner = this;
            af.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddForm7 af = new AddForm7();
            af.Owner = this;
            af.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddForm8 af = new AddForm8();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource.EndEdit();
            сотрудникTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            клиентBindingSource.EndEdit();
            клиентTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            квалификацияBindingSource.EndEdit();
            квалификацияTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            должностьBindingSource.EndEdit();
            должностьTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            полBindingSource.EndEdit();
            полTableAdapter.Update(_Информационная_система_Фитнес_клуба_Fitness_house_mdbDataSet);
        }
    }
}
