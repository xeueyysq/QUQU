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
                MessageBox.Show("Ты отгадал загадку и заключенные помогли тебе сбежать. Ты вернулся ко своей армии", "Побег удался", MessageBoxButtons.OK);
                this.Hide();
                new Chapter4().Show();
            }
            else
            {
                MessageBox.Show("Ящеры съели вас за то, что вы не отгадали простейшую загадку", "Побег провалился", MessageBoxButtons.OK);
                this.Hide();
                new Lose().Show();
                //Environment.Exit(0);
            }
        }

        private void Quiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
