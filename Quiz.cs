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
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "земля" || textBox4.Text == "Земля")
            {
                this.Hide();
                new Chapter4().Show();
            }
            else
            {
                MessageBox.Show("Ящеры съели вас за то, что вы не отгадали простейшую загадку", "Чел, ты нулевый", MessageBoxButtons.OK);
                this.Hide();
                new Lose().Show();
                //Environment.Exit(0);
            }
        }
    }
}
