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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты выбираешь прямолинейную атаку. " +
                "Твоя отвага воодушевляет русских воинов, и вы наносите мощный удар, разгромляя ящеров. " +
                "Победа достается русским, и они заслуживают твое уважение и признание.", "Атака напрямую", MessageBoxButtons.OK);
            this.Hide();
            new Form3().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ты решаешь обойти фланги врага и атаковать их сзади. " +
                "Твое тактическое мастерство позволяет обмануть ящеров, и они оказываются в ловушке. " +
                "Русские воины наносят сокрушительный удар, положив конец вражескому сопротивлению. " +
                "Победа достается русским, и твое имя становится легендарным.", "Обход флангов", MessageBoxButtons.OK);
            this.Hide();
            new Form3().Show();
        }
    }
}
