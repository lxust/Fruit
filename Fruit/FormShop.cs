using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit
{
    public partial class FormShop : Form
    {
        public FormShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.player.cash >= 50 && Form1.player._help <= 1)
            {
                Form1.player.cash -= 50;
                Form1.player._help++;
                Form1.player.UpdateInfo();
                Close();

            }
            else
                MessageBox.Show("вы не можете купить подсказку!");
        }
    }
}
