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
    public partial class Chapter2 : Form
    {
        public Chapter2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь напасть на крепость с фронта. " +
                "Враги встречают вас огнем, но ты сумел предвидеть их действия и разгромить защиту. " +
                "Твоя атака приносит победу русским, и ты становишься героем народа.", "Фронтальная атака", MessageBoxButtons.OK);
            this.Hide();
            new Chapter4().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь использовать подкопы для проникновения внутрь крепости. " +
                "Твои специальные знания и навыки позволяют тебе незаметно проникнуть внутрь. " +
                "Однако, ты оказываешься в западне и попадаешь в плен к ящерам. " +
                "Ты стал заложником, и твоя судьба зависит от того, сможешь ли ты найти способ освободиться.", "Подкопы", MessageBoxButtons.OK);
            this.Hide();
            new Chapter3().Show();
        }

        private void Chapter2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
