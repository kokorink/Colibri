using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class AppMainForm : Form
    {


        public AppMainForm()
        {
            InitializeComponent();
            if (checkBox11.Checked == true)
                comboBox13.Enabled = false;
            dataGridView11.RowCount = 14;
            dataGridView11.Rows[0].Cells[0].Value = "Создание";
            dataGridView11.Rows[1].Cells[0].Value = "Согласование НО";
            dataGridView11.Rows[2].Cells[0].Value = "Согласование ГД";
            dataGridView11.Rows[3].Cells[0].Value = "Назначание РП";
            dataGridView11.Rows[4].Cells[0].Value = "Подготовка спецификации";
            dataGridView11.Rows[5].Cells[0].Value = "Расчёт спецификации";
            dataGridView11.Rows[6].Cells[0].Value = "Подготовка КП";
            dataGridView11.Rows[7].Cells[0].Value = "Закупка";
            dataGridView11.Rows[8].Cells[0].Value = "Назначение бригады";
            dataGridView11.Rows[9].Cells[0].Value = "Монтаж";
            dataGridView11.Rows[10].Cells[0].Value = "ПСИ";
            dataGridView11.Rows[11].Cells[0].Value = "Подготовка документации";
            dataGridView11.Rows[12].Cells[0].Value = "Подписание актов";
            dataGridView11.Rows[13].Cells[0].Value = "Согласование закрытия";
        }


        private void Exit(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
            

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
                comboBox13.Enabled = false;
            else comboBox13.Enabled = true;
        }

        private void button57_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.ShowDialog();
        }
    }
}
