using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit
{
    public class Player
    {
        public Player(Label lblMoney, Label lblLvl, Label lblHelp) 
        { 
            this.lblMoney = lblMoney;
            this.lblLvl = lblLvl;
            this.lblHelp = lblHelp;
        }

        public Label lblMoney;
        public Label lblLvl;
        public Label lblHelp;
        public int lvl = 0;
        public int cash = 0;
        public int mestaces = 0;
        public int _help = 0;
        public int usethelp = 0;

        public void UpdateInfo()
        {
            lblLvl.Text = lvl.ToString();
            lblMoney.Text = cash.ToString();
            lblHelp.Text = _help.ToString();
        }
    }
}
