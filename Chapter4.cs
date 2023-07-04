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
    public partial class Chapter4 : Form
    {
        public Chapter4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь нанести удар в самый подходящий момент. " +
                "Твое стратегическое мышление и отличная координация войск позволяют вам разгромить ящеров" +
                " и завершить войну в пользу русских. " +
                "Ты становишься легендой и наследником великих воинов.", "Своевременная атака", MessageBoxButtons.OK);
            this.Hide();
            new Win().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь организовать засаду и напасть на ящеров внезапно. " +
                "Однако, твой план обнаруживается, и ящеры устраивают контратаку. " +
                "Битва оказывается крайне жестокой и тяжелой, и вы не справляетесь с противником. " +
                "Война продолжается, и ее исход остается неопределенным.", "Засада", MessageBoxButtons.OK);
            this.Hide();
            new Chapter5().Show();
        }

        private void Chapter4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
