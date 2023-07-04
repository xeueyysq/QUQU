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
    public partial class Chapter5 : Form
    {
        public Chapter5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь идти на компромисс и заключить мирное соглашение с ящерами. " +
                "Русские и ящеры начинают жить вместе в относительном мире," +
                " сохраняя свою идентичность и культуру," +
                " восстанавливая цивилизацию.", "Своевременная атака", MessageBoxButtons.OK);
            this.Hide();
            new Win().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь уничтожить ящеров до последнего и не давать им шанса возродиться. " +
                "Цена победы оказывается высокой, и мир окутывает мрак вечной войны.", "Засада", MessageBoxButtons.OK);
            this.Hide();
            new Lose().Show();
        }
    }
}
