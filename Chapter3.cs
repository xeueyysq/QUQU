using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUQU
{
    public partial class Chapter3 : Form
    {
        public Chapter3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь попытаться выйти из плену самостоятельно. " +
                "Используя свои навыки и сообразительность, ты находишь выход и сумел сбежать. " +
                "Теперь ты свободен и можешь продолжить борьбу с ящерами.", "Выбраться самостоятельно", MessageBoxButtons.OK);
            //this.Hide();
            //new Chapter4().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь не рисковать и пытаешься найти союзников внутри крепости. " +
                "Твоя находчивость позволяет тебе убедить некоторых ящеров перейти на твою сторону. " +
                "Вместе с ними ты совершаешь побег и возвращаешься к русским, чтобы объединиться и продолжить сопротивление.", "Помощь союзников", MessageBoxButtons.OK);
            this.Hide();
            new Quiz().Show();
        }
    }
}
