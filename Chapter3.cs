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
                "Используя свои навыки и сообразительность, ты находишь выход, но тебя уже поджидали ящеры. " +
                "Тебе не стали жалеть и тот же час расправились.", "Выбраться самостоятельно", MessageBoxButtons.OK);
            //this.Hide();
            //new Chapter4().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь не рисковать и пытаешься найти союзников внутри крепости. " +
                "Твоя находчивость позволяет тебе убедить некоторых ящеров перейти на твою сторону. " +
                "Но взамен надо отгадать их загадку.", "Помощь сокамерников", MessageBoxButtons.OK);
            //this.Hide();
            //new Quiz().Show();
        }
    }
}
